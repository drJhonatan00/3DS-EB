<img width="1134" height="1118" alt="1000032261" src="https://github.com/user-attachments/assets/383a2d28-4b3e-4973-b098-9078d7b799d5" />

---

# 3DS-EB
3DS-EB is a complete ground-up C# re-engineering of Asia81's HackingToolkit9DS, built to deliver maximum speed, a clean interface, and seamless 3DS ROM extraction/rebuilding without the performance bottlenecks of the original toolchain.

`3DS-EB` completely re-architects the original toolchain, replacing slow legacy scripts with a optimized **C# / .NET** engine. It delivers significantly faster extraction and rebuilding speeds, a cleaner UI, and an enhanced workflow for Nintendo 3DS ROM hacking, binary extraction, and localization.

<img width="1204" height="619" alt="1000032263" src="https://github.com/user-attachments/assets/45c03925-b885-49e4-928c-92e6400aa700" />


---

## Why 3DS-EB?

* **Massive Performance Boost:** Rewritten in native C# to eliminate process overhead, execution bottlenecks, and slow batch operations.
* **Modern UI & Usability:** Streamlined user interface designed for efficiency, replacing clunky command prompts with an intuitive, error-free setup.
* **Complete 3DS Toolchain:** Full support for extracting, editing, and rebuilding `.3ds`, `.cia`, `.cxi`, `ExeFS`, `RomFS`, and `NCCH` containers.
* **Automated Workflow:** Single-click operations for mass asset extraction and binary patching.

---

## Key Features

* **3DS & CIA Unpacking/Repacking:** High-speed handling of encrypted/decrypted 3DS storage formats.
* **RomFS & ExeFS Extraction:** Rapid access to game resources, dialog files, textures, and executable code.
* **Header & Banner Editing:** Integrated tools for modifying 3DS system banners and metadata.
* **Enhanced Error Handling:** Smart logging and automated checks to prevent corrupt builds during repacking.

<img width="849" height="515" alt="1000032264" src="https://github.com/user-attachments/assets/a1e7f877-2d20-4364-b6a1-5e5ac1153428" />


---

## Languages
* English
* Español
* Português
* 简体中文
* 日本語
* 한국어
* Deutsch
* Français
* Italiano

<img width="331" height="495" alt="1000032262" src="https://github.com/user-attachments/assets/ff148f4b-2560-4f64-80bc-aeb400dacbff" />


---

## Performance Comparison

| Task | Original HackingToolkit9DS | 3DS-EB (C# Edition) |
| :--- | :--- | :--- |
| **Language Base** | Batch / External Binaries | **Native C# (.NET)** |
| **RomFS Extraction** | Slow / Single-threaded | **Optimized Multi-threaded Stream** |
| **Interface** | Legacy CMD Prompt | **Modern UI / Fast CLI** |
| **Reliability** | Prone to path spaces errors | **Robust Input Validation** |

---

## Technical Stack

* **Language:** C# (.NET 8.0 / .NET Framework)
* **Target Formats:** `.3ds`, `.cia`, `.cxi`, `.app`, `.bin` (ExeFS/RomFS)
* **Base Architecture:** Inspired by *HackingToolkit9DS v12+* by Asia81

---

## Getting Started

### Prerequisites
* Windows 10/11 (or Linux via Mono/.NET Core)
* [.NET Desktop Runtime](https://dotnet.microsoft.com/)

### Running the Application

1. Download the latest release from the **[Releases](../../releases)** tab.
2. Extract the ZIP file to a folder of your choice.
3. Run `3DS-EB.exe`.
4. Place your decrypted `.3ds` or `.cia` file in the working directory and select your operation.

---

## Credits & Acknowledgments

* **Asia81:** Creator of the original [HackingToolkit9DS](https://github.com/Asia81/HackingToolkit3DS).
* **3DS Modding Community:** For the underlying format specifications and research.

---

## Legal & Disclaimer

`3DS-EB` is an educational research tool built for reverse engineering, homebrew development, and game localization. It **does not** contain copyrighted Nintendo SDK components, system keys, or proprietary game assets. Users are responsible for dumping and decrypting their own legally obtained software.

---

## License

Distributed under the MIT License. See `LICENSE` for details.
