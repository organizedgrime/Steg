# Steg
This project is a practical application designed for LSB Steganography. You can use this program to hide any data in a PNG image. The file type of the embedded data can be identified if it is a recognized MIME type(see http://www.freeformatter.com/mime-types-list.html). Note that this program is intended for use on Windows only and relies on WinForms and the .NET framework.

## Usage Tutorial
### Embedding Data
Select the image in which you'd like to embed your data, the folder which you'd like to put your modified image, and the file or text that you'd like to hide in it. If you want to be able to extract the file from your image without residual LSB data, be sure to check the 'Use Endmarker' box.
### Extracting Data
Select the file which contains the hidden information, and the folder which you'd like to extract your data to.
If you used the endmarker feature when embedding the data, which is highly recommended(especially for non-plaintext), make sure to check the "Trim Endmarker" box, so as to cut any non-essential LSB data.

## Download
To download, check out the releases page:
https://github.com/nicosogangstar/Steg/releases
