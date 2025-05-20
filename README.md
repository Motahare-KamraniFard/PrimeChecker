
# 🧮 PrimeChecker

A simple C# console application that checks whether a given number is a **prime number** or not.

---

## 📌 Overview

PrimeChecker is a beginner-friendly C# application that allows users to input a number and find out whether it's a prime. The application handles various edge cases, validates user input, and offers an interactive experience through the console.

---

## 🛠️ Features

- ✅ Checks for prime numbers
- 📥 Input validation:
  - Prevents empty or whitespace inputs
  - Rejects non-integer values
  - Rejects numbers less than 2
- 💬 User-friendly error messages
- 🔁 Allows repeated checks until the user exits
- 🚪 Supports `"exit"` command to quit anytime

---

## 🧑‍💻 Technologies Used

- **C#**
- **.NET Console Application**
- Basic OOP principles
- `Nullable`, `TryParse`, and `out` parameters
- Modular structure (Helpers, Logic, Program)

---

## 📁 Project Structure

```bash
PrimeChecker/
├── Helper/
│   └── Validation.cs       # Input validation logic
├── Logic/
│   └── PChecker.cs         # Prime number checking logic
├── Program.cs              # Main program entry point
└── README.md               # Project documentation
```

---

## 🚀 Getting Started

1. Clone the repository:

```bash
git clone https://github.com/Motahare-KamraniFard/PrimeChecker.git
```

2. Open the solution in Visual Studio (or your preferred IDE).

3. Run the project (F5 or `dotnet run` from CLI).

4. Follow the console instructions.

---

## 💡 Example

```
Enter a number to check if it's prime (or 'exit' to quit):
> 17
17 is a prime number.

Enter a number to check if it's prime (or 'exit' to quit):
> 18
18 is not a prime number.

Enter a number to check if it's prime (or 'exit' to quit):
> exit
```

---

## 🌱 Future Enhancements

- [ ] Add UI using WinForms or WPF
- [ ] Accept multiple numbers at once
- [ ] Show list of primes up to a given number
- [ ] Write unit tests for helper and logic methods

---

## 🤝 Contributing

Pull requests are welcome. Feel free to fork the repository and improve the code or documentation!

---

## 🪪 License

This project is licensed under the MIT License.

---

## 🧑‍🎓 Author

**Motahare Kamrani Fard**  
🔗 [GitHub Profile](https://github.com/Motahare-KamraniFard)
