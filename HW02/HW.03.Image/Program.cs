// See https://aka.ms/new-console-template for more information
// 1. Создание ридера для чтения текста из файла по пути E:\vika-vaiti\image.txt
// 2. Копирование содержимого файла в строку
// 3. Преобразование строки в  массив строк
// 4. Создание массива для хранения байтовых значений
// 5. Создание цикла: преобразование строк в байт
// 6. Запись массива байт в файл
// 7. Удаление неуправляемых ресурсов

StreamReader textReader = 
    new StreamReader(@"..\..\..\image.txt", true);
string textReaderResult = textReader.ReadToEnd();
string[] arrayOfTextResult = textReaderResult.Split(' ');
byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
for (int i = 0; i < arrayOfTextResult.Length - 1; i++) 
{
    byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
    imageBytes[i] = binary;
}
File.WriteAllBytes(@"..\..\..\image.png", imageBytes);
textReader.Dispose();


