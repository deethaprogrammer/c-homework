static class Program
{
    static void Main()
    {
        List<string> fileList = [
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        ];

        string whichFileToDelete = fileList[0];

        string confirm = "";

        Console.WriteLine("File selected to delete: " + whichFileToDelete);
        // Your code goes here
        do
        {
            Console.WriteLine("Really delete this file? (y/n)");
            confirm = Console.ReadLine();
        }while(confirm != "n" && confirm != "y");
        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
    }
}
