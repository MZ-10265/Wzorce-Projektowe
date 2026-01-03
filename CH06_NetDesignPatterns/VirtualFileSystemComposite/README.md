# Virtual File System Composite	


## Opis
- `INode` – wspólny interfejs dla plików i folderów  
- `FileNode` – liœæ (plik, bez dzieci)  
- `FolderNode` – kompozyt (folder zawieraj¹cy inne elementy)

Folder oblicza swój rozmiar jako sume rozmiarów wszystkich dzieci (przy uzyciu rekurencji)