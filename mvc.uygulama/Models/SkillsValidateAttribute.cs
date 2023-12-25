namespace mvc.uygulama.Models
{
    internal class SkillsValidateAttribute : Attribute
    {
        public string[] Allowed;

        public string ErrorMessage { get; set; }
    }
}