using System;
using System.IO;
using System.Linq;

class ConsoleFileExplorer
{
    static void Main(string[] args)
    {
        Start();
    }

    static void Start()
    {
        while (true)
        {
            Console.Clear();
            ListDrives();
            Console.WriteLine("Введите букву диска, чтобы выбрать или 'exit' для выхода.");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (DriveInfo.GetDrives().Any(d => d.Name.StartsWith(input.ToUpper())))
            {
                DriveInfo selectedDrive = DriveInfo.GetDrives().First(d => d.Name.StartsWith(input.ToUpper()));
                ExploreDirectory(selectedDrive.RootDirectory);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку.");
                Console.ReadKey();
            }
        }
    }

    static void ListDrives()
    {
        Console.WriteLine("Доступные диски:");
        foreach (var drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
            {
                Console.WriteLine($"{drive.Name} - {drive.VolumeLabel}, Объем: {drive.TotalSize / (1024 * 1024 * 1024)} GB, Доступно: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB");
            }
        }
    }

    static void ExploreDirectory(DirectoryInfo directory)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Содержимое каталога: {directory.FullName}");
            ListDirectoryContents(directory);
            Console.WriteLine("Выберите действие: [O] - открыть файл, [C] - создать каталог, [F] - создать файл, [D] - удалить, [..] - вернуться назад, [Exit] - закончить");
            string input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "O":
                    OpenFile(directory);
                    break;
                case "C":
                    CreateDirectory(directory);
                    break;
                case "F":
                    CreateFile(directory);
                    break;
                case "D":
                    DeleteItem(directory);
                    break;
                case "..":
                    directory = directory.Parent ?? directory; 
                    break;
                case "EXIT":
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    static void ListDirectoryContents(DirectoryInfo directory)
    {
        try
        {
            DirectoryInfo[] directories = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();

            foreach (var dir in directories)
            {
                Console.WriteLine($"[DIR] {dir.Name}");
            }
            foreach (var file in files)
            {
                Console.WriteLine($"[FILE] {file.Name}");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Недостаточно прав для доступа к этому каталогу.");
        }
    }

    static void OpenFile(DirectoryInfo directory)
    {
        Console.Write("Введите имя файла для открытия: ");
        string fileName = Console.ReadLine();

        try
        {
            FileInfo file = new FileInfo(Path.Combine(directory.FullName, fileName));
            if (file.Exists)
            {
                Console.WriteLine(File.ReadAllText(file.FullName));
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        Console.ReadKey();
    }

    static void CreateDirectory(DirectoryInfo directory)
    {
        Console.Write("Введите название нового каталога: ");
        string dirName = Console.ReadLine();
        Directory.CreateDirectory(Path.Combine(directory.FullName, dirName));
        Console.WriteLine("Каталог создан.");
        Console.ReadKey();
    }

    static void CreateFile(DirectoryInfo directory)
    {
        Console.Write("Введите название нового файла: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Введите текст для записи в файл (нажмите Enter для завершения ввода):");
        string textInput = Console.ReadLine();

        File.WriteAllText(Path.Combine(directory.FullName, fileName), textInput);
        Console.WriteLine("Файл создан.");
        Console.ReadKey();
    }

    static void DeleteItem(DirectoryInfo directory)
    {
        Console.Write("Введите имя файла или каталога для удаления: ");
        string itemName = Console.ReadLine();
        string fullPath = Path.Combine(directory.FullName, itemName);

        if (Directory.Exists(fullPath))
        {
            Console.Write("Вы уверены, что хотите удалить этот каталог? (y/n): ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Directory.Delete(fullPath, true);
                Console.WriteLine("\nКаталог удален.");
            }
        }
        else if (File.Exists(fullPath))
        {
            Console.Write("Вы уверены, что хотите удалить этот файл? (y/n): ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                File.Delete(fullPath);
                Console.WriteLine("\nФайл удален.");
            }
        }
        else
        {
            Console.WriteLine("\nЭлемент не найден.");
        }
        Console.ReadKey();
    }
}
