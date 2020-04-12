# Atbash-Cipher
Atbash Cipher
The Atbash cipher is a particular type of monoalphabetic cipher formed by taking the alphabet and mapping it to its reverse, so that the first letter becomes the last letter, the second letter becomes the second to last letter, and so on. 
(https://en.wikipedia.org/wiki/Atbash)
E.g. A becomes Z, B becomes Y and so on.

## Atbash Class
This class encrypts and decrypts the provided string into its atbash cipher or vice versa. As this class is a simple implementation so, if passed string contains characters other than upper case and lower case alphabets, they will be skipped by both encrytion and decryption method.

## Usage
Add the `Atbash` class to your project and call the `Encrypt()` method for encryption and `Decrypt()` method for decryption.
#### Example
```
string encryptedValue = Atbash.Encrypt(value);
string decryptedValue = Atbash.Decrypt(encryptedValue);
```
