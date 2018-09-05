# Cryptography-Class
This is where all my crypt stuff goes, it's pretty fresh not gonna lie

Arithmetic Ciphers: each of these have relativly small keyspaces so I made them into "brute force" programs that run all possible keys at once for an inputted string
1. Caesar Cipher - takes the values of each latin character as an array indexed 0 and adds a certain key (modulo 26)
2. Multiplicative Cipher - takes value adn multiplies with number relativly prime to 26
3. Affine Cipher - Multiplicative Cipher followed by a Caesar shift, two encryptions in one
