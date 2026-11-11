using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Services.Models._AuthDtos.SSODtos;
using Services.Repositories.Interface._IAuth.ISSO;

namespace Client.Components.Auth;

public partial class ForgotPassword : BaseComponent
{
    [Inject] private ISsoService SsoService { get; set; } = null!;
    [Inject] private IToastService ToastService { get; set; } = null!;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;


    private EditContext EditContext { get; set; } = null!;
    private ValidationMessageStore? messageStore;
    private ForgotPasswordDto ForgotPasswordDto { get; set; } = new();

    private bool IsSubmit { get; set; }
    private bool ShowRequestCode { get; set; }
    private bool ShowForgotPassword { get; set; }

    private bool ShowLoginPassword { get; set; }
    private bool ShowLoginPasswordConfirm { get; set; }

    private int TimerSeconds { get; set; } = 0;
    private CancellationTokenSource? timerCts;

    protected override void OnInitialized()
    {
        EditContext = new EditContext(ForgotPasswordDto);
        messageStore = new ValidationMessageStore(EditContext);
    }

    private async Task SubmitPassword()
    {
        try
        {
            IsSubmit = true;

            var result = await SsoService.ForgotPassword(ForgotPasswordDto);

            if (result)
            {
                ToastService.SuccessAlertToast();
                NavigationManager.NavigateTo("/Login");
            }

            IsSubmit = false;
        }
        catch (Exception e)
        {
            IsSubmit = false;
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    private async Task VerifyTotp()
    {
        try
        {
            messageStore!.Clear();
            if (ForgotPasswordDto.PhoneNumber == null || ForgotPasswordDto.PhoneNumber.Length < 11)
            {
                messageStore!.Add(EditContext.Field(nameof(ForgotPasswordDto.PhoneNumber)),
                    "لطفا شماره تماس صحیح وارد کنید");
                EditContext.NotifyValidationStateChanged();
                return;
            }

            if (ForgotPasswordDto.TotpCode == null || ForgotPasswordDto.TotpCode.Length < 6)
            {
                messageStore!.Add(EditContext.Field(nameof(ForgotPasswordDto.TotpCode)), "لطفا کد صحیح وارد کنید");
                EditContext.NotifyValidationStateChanged();
                return;
            }

            IsSubmit = true;

            var result = await SsoService.VerifyTotpForgotPassword(ForgotPasswordDto);

            if (result)
            {
                ShowForgotPassword = true;
            }
            IsSubmit = false;
        }
        catch (Exception e)
        {
            IsSubmit = false;
            ToastService.ErrorAlertToast(e.Message);
        }
    }

    private async Task RequestCode()
    {
        try
        {
            messageStore!.Clear();
            if (ForgotPasswordDto.PhoneNumber == null || ForgotPasswordDto.PhoneNumber.Length < 11)
            {
                messageStore!.Add(EditContext.Field(nameof(ForgotPasswordDto.PhoneNumber)), "لطفا شماره تماس صحیح وارد کنید");
                EditContext.NotifyValidationStateChanged();
                return;
            }

            IsSubmit = true;
            var result = await SsoService.RequestTotp(ForgotPasswordDto);

            ForgotPasswordDto.SecretKey = result.SecretKey;

            if (result.ExpireSecond > 0)
            {
                ShowRequestCode = true;
                TimerSeconds = result.ExpireSecond;

                if (timerCts != null)
                {
                    await timerCts.CancelAsync();
                }
                timerCts = new CancellationTokenSource();
                var ct = timerCts.Token;
                IsSubmit = false;
                while (TimerSeconds > 0 && !ct.IsCancellationRequested)
                {
                    await Task.Delay(1000, ct);
                    TimerSeconds--;
                    StateHasChanged();
                }
            }
        }
        finally
        {
            IsSubmit = false;
        }
    }
}