﻿using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Sys = Cosmos.System;

namespace sexOSKernel.Commands
{
    public class File : Command
    {
        public static string currentDirectory = @"0:\"; // Initialize the current directory as root.

        public File(string name, string description) : base(name, description) { }

        public override string Execute(string[] args)
        {
            string response = "";
            switch (args[0])
            {
                case "help"://ar fi mai ok sa avem aici help
                    response = "- create: New file at path. Usage: file create PATH\\NAME.EXT\n" +
            "delete: Remove file at path. Usage: file delete PATH\\NAME\n" +
            "createdir: New directory at path. Usage: file createdir PATH\n" +
            "removedir: Delete directory at path. Usage: file removedir PATH\n" +
            "writestring: Write text to file. Usage: file writestring PATH\\NAME TEXT\n" +
            "readstring: Read file content. Usage: file readstring PATH\n" +
            "listdir: List path contents. Usage: file listdir PATH\n" +
            "mv: Move file/directory. Usage: file mv SOURCE DEST\n" +
            "cp: Copy file/directory. Usage: file cp SOURCE DEST\n" +
            "cd: Change directory. Usage: file cd PATH\n" +
            "pwd: Show current directory. Usage: file pwd\n" +
            "tree: Display directory tree. Usage: file tree [PATH]\n" +
            "finddir: Recursively finds directories or files. Usage: file finddir NAME\n";

                    break;
                case "pwd":
                    response = currentDirectory;
                    break;

                case "cd":
                    if (args.Length < 2)
                    {
                        response = "Error: No directory specified.";
                    }
                    else
                    {
                        string newPath = args[1];
                        if (newPath == "..")
                        {
                            // În cazul în care nu suntem deja în root
                            if (currentDirectory != @"0:\")
                            {
                                // Navigăm la directorul părinte
                                var parentDir = Path.GetDirectoryName(currentDirectory.TrimEnd('\\'));
                                // Asigurăm că nu setăm currentDirectory la null
                                currentDirectory = parentDir == null ? @"0:\" : parentDir + @"\";
                            }
                        }
                        else
                        {
                            // Construim calea potențial nouă și verificăm dacă există
                            string potentialNewPath = Path.Combine(currentDirectory, newPath).TrimEnd('\\') + @"\";
                            if (Directory.Exists(potentialNewPath))
                            {
                                currentDirectory = potentialNewPath;
                            }
                            else
                            {
                                response = "Error: Directory does not exist.";
                                break;
                            }
                        }
                        response = "Current directory is now: " + currentDirectory;
                    }
                    break;

                case "create":
                    try
                    {
                        string fullPath = Path.Combine(currentDirectory, args[1]);
                        Sys.FileSystem.VFS.VFSManager.CreateFile(fullPath);
                        response = "Your file: " + args[1] + " was successfully created!";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                    }
                    break;

                case "delete":
                    try
                    {
                        string fullPath = Path.Combine(currentDirectory, args[1]);
                        Sys.FileSystem.VFS.VFSManager.DeleteFile(fullPath);
                        response = "Your file: " + args[1] + " was successfully removed!";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                    }
                    break;

                case "createdir":
                    try
                    {
                        string fullPath = Path.Combine(currentDirectory, args[1]);
                        Sys.FileSystem.VFS.VFSManager.CreateDirectory(fullPath);
                        response = "Successfully created the directory " + args[1];
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                    }
                    break;

                case "removedir":
                    try
                    {
                        string fullPath = Path.Combine(currentDirectory, args[1]);
                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory(fullPath, true);
                        response = "Successfully deleted the directory " + args[1];
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                    }
                    break;

                case "listdir":
                    try
                    {
                        var fullPath = Path.Combine(currentDirectory, args.Length > 1 ? args[1] : "");
                        var directories = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(fullPath);
                        StringBuilder sb = new StringBuilder();
                        foreach (var dir in directories)
                        {
                            
                            if(dir.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                            {
                                sb.AppendLine((string)"D-" + dir.mName + (string)" " + ( dir.mSize));
                            }
                            else sb.AppendLine((string)"-" + dir.mName + (string)" " + (dir.mSize));

                        }
                        response = sb.ToString();
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                    }
                    break;
                case "tree":
                    try
                    {
                        string path = currentDirectory; // Default to current directory
                        if (args.Length > 1)
                        {
                            // If a path is provided with the tree command, use it
                            path = Path.Combine(currentDirectory, args[1]);
                        }
                        response = GenerateTree(path, "", true);
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                    }
                    break;
                case "writestring": //file writestring 0:\Myfile.txt "abcacaca"
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(Path.Combine(currentDirectory, args[1])).GetFileStream();
                        if (fs.CanWrite) //can write to the file
                        {
                            // Clear the content of the file before writing new content
                            fs.SetLength(0); // This line flushes the existing content by setting the file length to 0

                            int ctr = 0;
                            StringBuilder sb = new StringBuilder();
                            foreach (String s in args)
                            {
                                if (ctr > 1)
                                    sb.Append(s + ' ');
                                ++ctr;
                            }
                            //need to convert the string to byte sequences
                            //byte array
                            String txt = sb.ToString();
                            Byte[] data;
                            data = Encoding.ASCII.GetBytes(txt.Substring(0, txt.Length - 1));
                            fs.Write(data, 0, data.Length);
                            fs.Close();
                            response = "Successfully wrote to the file!";
                        }
                        else
                        {
                            response = "Unable to write to file, it is not open for writing.";
                        }
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                    }
                    break;
                case "readstring":
                    if (args.Length == 2)
                    {
                        string filePath = Path.Combine(currentDirectory, args[1]);
                        response = ReadStringFromFile(filePath);
                    }
                    else
                    {
                        response = "Error: Incorrect usage. Correct usage: readstring [path]";
                    }
                    break;
                case "cp":
                    if (args.Length < 3)
                    {
                        response = "Error: Missing arguments. Correct usage: cp [source] [destination]";
                    }
                    else
                    {
                        string sourcePath = Path.Combine(currentDirectory, args[1]);
                        string destinationPath = Path.Combine(currentDirectory, args[2]);
                        response = CopyFile(sourcePath, destinationPath);
                    }
                    break;
                case "mv":
                    if (args.Length < 3)
                    {
                        response = "Error: Missing arguments. Correct usage: mv [source] [destination]";
                    }
                    else
                    {
                        string sourcePath = Path.Combine(currentDirectory, args[1]);
                        string destinationPath = Path.Combine(currentDirectory, args[2]);
                        response = MoveFile(sourcePath, destinationPath);
                    }
                    break;

                case "finddir":
                    if (args.Length < 2)
                    {
                        response = "Error: No directory name specified.";
                    }
                    else
                    {
                        string searchName = args[1];
                        string searchPath = currentDirectory;
                        if (args.Length > 2) // If a path is provided
                        {
                            searchPath = Path.Combine(currentDirectory, args[2]);
                        }

                        if (!Directory.Exists(searchPath))
                        {
                            response = $"Error: Search path does not exist - {searchPath}";
                            break;
                        }

                        try
                        {
                            List<string> foundPaths = new List<string>();
                            SearchDirectoriesRecursively(searchPath, searchName, foundPaths);

                            if (foundPaths.Any())
                            {
                                StringBuilder sb = new StringBuilder();
                                sb.AppendLine($"Found directories matching '{searchName}':");
                                foreach (var path in foundPaths)
                                {
                                    sb.AppendLine(path);
                                }
                                response = sb.ToString();
                            }
                            else
                            {
                                response = $"No directories found starting with '{searchName}' in path {searchPath}";
                            }
                        }
                        catch (Exception ex)
                        {
                            response = $"Error searching directories: {ex.Message}";
                        }
                    }
                    break;
                default:
                    response = "Invalid input or command not implemented.";
                    break;
            }
            return response;
        }
        private void SearchDirectoriesRecursively(string searchPath, string searchName, List<string> foundPaths)
        {
            try
            {
                // Get directories in the current directory
                var directories = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(searchPath);

                foreach (var dir in directories)
                {
                    // Check if directory name matches the search term
                    if (dir.mName.StartsWith(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        foundPaths.Add(Path.Combine(searchPath, dir.mName));
                    }

                    // Recursively search in subdirectories
                    if (dir.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                    {
                        SearchDirectoriesRecursively(Path.Combine(searchPath, dir.mName), searchName, foundPaths);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the search
                Console.WriteLine($"Error during recursive search: {ex.Message}");
            }
        }

        private string ReadStringFromFile(string filePath)
        {
            try
            {
                var file = VFSManager.GetFile(filePath);
                if (file == null)
                {
                    return "Error: File does not exist.";
                }
                using (var fs = file.GetFileStream())
                {
                    if (fs.CanRead)
                    {
                        byte[] data = new byte[fs.Length]; // Adjusted to read full file
                        fs.Read(data, 0, data.Length);
                        return Encoding.ASCII.GetString(data);
                    }
                    else
                    {
                        return "Unable to read from file, not open for reading.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error reading from file: {ex.Message}";
            }
        }

        // In your File command class
        private string CopyFile(string sourcePath, string destinationPath)
        {
            // Adjust paths to be relative to currentDirectory
            sourcePath = Path.Combine(currentDirectory, sourcePath);
            destinationPath = Path.Combine(currentDirectory, destinationPath);

            // Check if source is a file
            if (!VFSManager.FileExists(sourcePath))
            {
                return $"Error: Source file does not exist at {sourcePath}.";
            }

            // If destination ends with a slash, ensure it's treated as a directory
            if (destinationPath.EndsWith(@"\") || destinationPath.EndsWith("/"))
            {
                // Ensure the directory exists
                VFSManager.CreateDirectory(destinationPath); // Adjust this method if necessary to fit your environment
                destinationPath = Path.Combine(destinationPath, Path.GetFileName(sourcePath));
            }
            else
            {
                // If destination directory (derived from destinationPath) doesn't exist, create it
                var destDirPath = Path.GetDirectoryName(destinationPath);
                if (!VFSManager.DirectoryExists(destDirPath))
                {
                    VFSManager.CreateDirectory(destDirPath);
                }
            }

            try
            {
                System.IO.File.Copy(sourcePath, destinationPath, true);
                return $"File copied successfully from {sourcePath} to {destinationPath}.";
            }
            catch (Exception ex)
            {
                return $"Error copying file: {ex.Message}";
            }
        }

        private string MoveFile(string sourcePath, string destinationPath)
        {
            // Adjust paths to be relative to currentDirectory
            sourcePath = Path.Combine(currentDirectory, sourcePath);
            destinationPath = Path.Combine(currentDirectory, destinationPath);

            // Check if source exists
            if (!VFSManager.FileExists(sourcePath))
            {
                return $"Error: Source file does not exist at {sourcePath}.";
            }

            // Ensure destination directory exists
            string destinationDirPath = Path.GetDirectoryName(destinationPath);
            if (!VFSManager.DirectoryExists(destinationDirPath))
            {
                VFSManager.CreateDirectory(destinationDirPath); // Create destination directory if it doesn't exist
            }

            try
            {
                // First, copy the file
                var copyResponse = CopyFile(sourcePath, destinationPath);
                if (!copyResponse.StartsWith("File copied successfully"))
                {
                    return copyResponse; // Return the error from copying
                }

                // If copy is successful, delete the source file
                VFSManager.DeleteFile(sourcePath);
                return $"File moved successfully from {sourcePath} to {destinationPath}.";
            }
            catch (Exception ex)
            {
                return $"Error moving file: {ex.Message}";
            }
        }

        private string GenerateTree(string directoryPath, string indent, bool last)
        {
            var sb = new StringBuilder();
            string directoryName = Path.GetFileName(directoryPath.TrimEnd('\\'));
            if (string.IsNullOrEmpty(directoryName))
            {
                directoryName = directoryPath; // For root directories, use the directory path itself
            }

            // First, handle the current directory name with the appropriate indent
            sb.AppendLine(indent + "+- " + directoryName);
            indent += last ? "   " : "|  ";

            // Try to get directories; catch exceptions if any (e.g., access denied)
            string[] directories;
            try
            {
                directories = Directory.GetDirectories(directoryPath);
            }
            catch
            {
                directories = new string[0]; // If access is denied or any error occurs, treat as if there were no subdirectories
            }

            // Process subdirectories
            for (int i = 0; i < directories.Length; i++)
            {
                bool isLastDirectory = i == directories.Length - 1;
                sb.Append(GenerateTree(directories[i], indent, isLastDirectory));
            }

            // Handling files - ensure files are displayed correctly
            string[] files;
            try
            {
                files = Directory.GetFiles(directoryPath);
            }
            catch
            {
                files = new string[0]; // Similar approach for files as for directories
            }

            for (int i = 0; i < files.Length; i++)
            {
                sb.AppendLine(indent + "+- " + Path.GetFileName(files[i]));
            }

            return sb.ToString();
        }


    }
}
