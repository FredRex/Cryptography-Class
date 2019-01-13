# Cryptography-Class
This is where all my crypt stuff goes, it's pretty fresh not gonna lie

To use the Neely Enigma Machine, download the .zip folder from the Neely Enigma Machine directory and remember to read the PDF Instruction Manual, thank you for using this software!

Update: The Neely Enigma Machine has been uploaded and contains a GUI with all the 8 private key ciphers learned this trimester in Cryptography

Arithmetic Ciphers: each of these have relativly small keyspaces so I made them into "brute force" programs that run all possible keys at once for an inputted string
1. Caesar Cipher - takes the values of each latin character as an array indexed 0 and adds a certain key (modulo 26)
2. Multiplicative Cipher - takes value and multiplies with number relativly prime to 26
3. Affine Cipher - Multiplicative Cipher followed by a Caesar shift, two encryptions in one

Word-Based Ciphers: these also run brute force

4. Codeward Cipher - create a new alphabet using a codeword special letter and using the positions in that alphabet to form encrypted way of writing
5. Vigenere - uses a codeword and a 26x26 matrix called a "tabula recta" to form an encrypted form of writing

Matrix Ciphers: these require keys in the form of matrices

6. 2x2 Hill Cipher - uses a 2x2 matrix made with integers modulo 26 to multiply the value of digraphs made from a string of latin characters, the program will add null characters like "x" or "q" if the inputted string is not divisible by 2
7. 3x3 Hill Cipher - same as 2x2 but with Trigraphs and divisiblity by 3 needed by strings
8. Playfair - a 5x5 Matrix made from 25 latin characters, use special rules made from digrpahs from the inputted string, divisibility by 2

//NOTE: KLING KRACKER IS CURRENTLY UNOPERABLE IN THE AFFINE CIPHER AND WILL NOT BE UNTIL I CAN PRIORITIZE IT ON A LATER DATE, IT WILL BE //UPADTED TO INCLUDE A VARIETY OF CIPHERS LATER ON, INCLUDING MY FINAL PROJECT
