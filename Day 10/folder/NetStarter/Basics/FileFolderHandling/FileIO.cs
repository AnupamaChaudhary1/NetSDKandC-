using System.IO;
class FileIO
{
     string folderPath = @"D:\NetSDKandC-.\Day 7\8\NetStarter\Basics\FileFolderHandling";
    //create a text file
    public void CreateFile()
    {
       
        string fileName = "Student.txt";
        string filePath = Path.Combine(folderPath, fileName);
        File.WriteAllText(filePath, "This the first line");
    }
    public void CreateFileWithinFolder(){
        string newFolderName = "Student";
        string newFolderPath = Path.Combine(folderPath, newFolderName);
        Directory.CreateDirectory(newFolderName);
        string fileName = "student1.txt";
        string filePath = Path.Combine(folderPath,newFolderName,fileName);

        File.WriteAllText(filePath, "This the first line");

    }

}