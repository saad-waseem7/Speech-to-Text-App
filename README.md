# 🎤 Speech Assistant

> A modern Windows Forms application that brings your words to life with Text-to-Speech and captures your voice with Speech-to-Text functionality.

## ✨ Key Features

### 🗣️ Speech Features
- **Text-to-Speech Wizard**
  - 📝 Convert your text into natural-sounding speech
  - 🎚️ Fine-tune speech speed and volume
  - ⏯️ Intuitive playback controls
  - 💾 Save voice output as WAV files
  - 📄 Import and read text files

- **Speech-to-Text Magic**
  - 🎙️ Convert your voice into text instantly
  - 📋 Quick copy to clipboard
  - 💫 Real-time voice recognition
  - 📥 Save transcriptions to your desktop

### 👤 User Experience
- 🔐 Secure and simple login system
- ✉️ Easy registration with email validation
- 🛡️ Password protection with visibility toggle
- 💽 Secure local database storage

### 🎯 Bonus Features
- 🎨 Clean, modern interface
- ⌨️ Smart keyboard navigation
- 📬 Built-in feedback system
- 📁 Efficient file management
- ⚡ Error prevention and validation

## 🔧 Requirements

- 💻 Windows Operating System
- 🎯 .NET Framework 4.7.2
- 📦 Microsoft SQL Server LocalDB
- 🗣️ System.Speech capability
- 🛠️ Visual Studio 2019 or newer (for development)

## 🚀 Quick Start

1. 📥 Clone the repository
2. 🔓 Open solution in Visual Studio
3. 📦 Install SQL Server LocalDB
4. ⚙️ Configure database connection
5. 🏃‍♂️ Build and launch!

## 💾 Database Setup

The app needs a SQL Server LocalDB database (`data.mdf`) with an `admin` table:

```sql
CREATE TABLE admin (
    email VARCHAR(100),
    username VARCHAR(50),
    _password VARCHAR(50),
    date_created DATETIME
)
```

## 📖 How to Use

1. 🔑 Start by logging in or creating an account
2. 🎯 Choose your feature:
   - 🗣️ Convert text to speech
   - 🎙️ Convert speech to text
   - 🎚️ Adjust voice settings
   - 💾 Save or load files
   - 🎵 Record speech output
3. 📬 Share your feedback to help us improve!

