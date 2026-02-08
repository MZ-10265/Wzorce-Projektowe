


var root = new FolderNode("root");

var documents = new FolderNode("Documents");
documents.Add(new FileNode("cv.pdf", 120));
documents.Add(new FileNode("notes.txt", 15));

var photos = new FolderNode("Photos");
photos.Add(new FileNode("img_001.jpg", 2000));
photos.Add(new FileNode("img_002.jpg", 1800));

var holidays = new FolderNode("Holidays");
holidays.Add(new FileNode("sea.png", 950));
holidays.Add(new FileNode("mountains.png", 1100));

//zagnieżdżenie folderu w folderze
photos.Add(holidays);

//składamy całe drzewo
root.Add(documents);
root.Add(photos);
root.Add(new FileNode("readme.md", 3));

//wypisujemy strukturę
Console.WriteLine("=== Struktura drzewa ===");
root.Print();

Console.WriteLine();
Console.WriteLine($"Rozmiar całego systemu: {root.GetSize()} KB");