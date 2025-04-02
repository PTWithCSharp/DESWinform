# DES Encryption & Decryption Tool

## Overview
This is a Windows Forms (.NET) application that allows users to encrypt and decrypt both files and text using the **DES (Data Encryption Standard) algorithm**. The tool ensures secure data handling and supports key management, padding, and proper error handling.

## Features
- **Encrypt and Decrypt Text**: Securely encrypt or decrypt input text using DES.
- **Encrypt and Decrypt Files**: Process entire files securely with DES encryption.
- **Key Management**: Users can provide a custom 8-byte key for encryption and decryption.
- **Padding Support**: Ensures encryption works even for non-multiples of 8-byte input.
- **User-Friendly Interface**: Simple and intuitive design for easy use.

## Requirements
- Windows OS
- .NET Framework / .NET Core
- Administrator permissions (if required for file operations)

## Usage
### Encrypting Text
1. Open the application.
2. Enter the text you want to encrypt.
3. Provide an 8-byte encryption key.
4. Click **Encrypt** to generate the encrypted text.

### Decrypting Text
1. Enter the encrypted text.
2. Provide the same 8-byte key used for encryption.
3. Click **Decrypt** to retrieve the original text.

### Encrypting a File
1. Click **Browse** to select a file.
2. Provide an 8-byte encryption key.
3. Click **Encrypt** to create an encrypted file.

### Decrypting a File
1. Click **Browse** to select an encrypted file.
2. Provide the same 8-byte key used for encryption.
3. Click **Decrypt** to restore the original file.

## Error Handling
- The software checks for **empty input**, **invalid keys**, and **corrupted encrypted files**.
- If decryption fails due to an incorrect key, an error message is displayed.
- For empty input or files, users are notified before proceeding.

## Notes
- The DES algorithm uses a **fixed 64-bit (8-byte) key**. Ensure you remember your key as lost keys mean **permanent data loss**.
- Always verify encryption results before deleting the original file.
- This tool is intended for educational purposes and basic encryption needs.


