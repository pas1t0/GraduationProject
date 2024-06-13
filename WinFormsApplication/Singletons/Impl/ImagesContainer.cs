
namespace WinFormsApplication.Singletons.Impl
{
    public class ImagesContainer : IImagesContainer
    {
        private static IImagesContainer _instance = new ImagesContainer();
        private readonly string _imagesDirectory;
        private readonly string _defaultFileName;
        private Image _imageDefault;
        private Dictionary<string, Image> _cachedImagesDictionary = new();

        public static IImagesContainer Instance => _instance;

        private ImagesContainer()
        {
            _imagesDirectory = "Images";
            _defaultFileName = "default.png";

            var defaultBitmapPath = GetImagePath(_defaultFileName);

            _imageDefault = Image.FromFile(defaultBitmapPath);
        }

        private string GetImagePath(string? imageName)
        {
            return Path.Combine(Environment.CurrentDirectory, _imagesDirectory, imageName ?? string.Empty);
        }

        public IEnumerable<string> GetImagesPaths()
        {
            var imagesPath = Path.Combine(Environment.CurrentDirectory, _imagesDirectory);

            return Directory.GetFiles(imagesPath).Select(x => x.Substring(imagesPath.Length + 1));
        }

        public Image Get(string? imageName)
        {
            var bitmapPath = GetImagePath(imageName);

            if (_cachedImagesDictionary.ContainsKey(bitmapPath))
            {
                return _cachedImagesDictionary[bitmapPath];
            }

            if (File.Exists(bitmapPath))
            {
                var image = Image.FromFile(bitmapPath);

                _cachedImagesDictionary.Add(bitmapPath, image);

                return image;
            }

            return _imageDefault;
        }
    }
}
