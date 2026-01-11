


Console.WriteLine("Composite");

var root = new FolderNode("root");

var docs = new FolderNode("Documents");
docs.Add(new FileNode("cv.pdf", 120));
docs.Add(new FileNode("notes.txt", 15));

var photos = new FolderNode("Photos");
photos.Add(new FileNode("img_001.jpg", 2000));
photos.Add(new FileNode("img_002.jpg", 1800));

var holidays = new FolderNode("Holidays");
holidays.Add(new FileNode("sea.png", 950));
holidays.Add(new FileNode("mountains.png", 1100));

photos.Add(holidays);

root.Add(docs);
root.Add(photos);
root.Add(new FileNode("readme.md", 3));

root.Print();

Console.WriteLine();
Console.WriteLine($"Total size: {root.GetSize()} KB");