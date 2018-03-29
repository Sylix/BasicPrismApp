namespace BasicPrismApp.Droid
{
    public class FileAccessHelper : BasicPrismApp.Helpers.IFileAccessHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, filename);
        }
    }
}