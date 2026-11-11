namespace Services.Models._AuthDtos.FormDtos;

public class FormGetMenuDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Icon { get; set; }
    public string? FormUrl { get; set; }
    public FormType FormType { get; set; }
    public int Order { get; set; }
    public List<FormGetMenuDto> Children { get; set; } = [];
}

public enum FormType
{
    Menu = 1,
    Page = 2,
}

public static class FormTypeHelper
{
    public static string MapFormType(this FormType formType) =>
        formType switch
        {
            FormType.Menu => "منو",
            FormType.Page => "صفحه",
            _ => ""
        };
}