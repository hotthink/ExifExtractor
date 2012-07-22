ExifExtractor
=============

Intended as the ultimate library for pulling relevant data from any Exif-supporting file format, with a particular focus on Canon (CR2) and Nikon (NEF) proprietary RAW formats.

In the initial stages the primary focus is on extracting Exif data from Canon .CR2 files.

References
----------

[Inside the Canon CR2 format](http://lclevy.free.fr/cr2/)

Example
-------

This doesn't actually work. This is just scrap notes for now.

`var image = ExifFile.Open(@"C:\example.cr2");`
`var format = image.FileFormat;`
`var timestamp = image.DateTimeOriginal;`

