namespace WinFormsApplication.Singletons
{
    public interface IImagesContainer
    {
        public IEnumerable<string> GetImagesPaths();

        public Image Get(string? imageName);
    }
}
