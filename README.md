# STARBASE-7 Systems Check: Bug Hunt

You have just been assigned to the space station **STARBASE-7**. The previous
programmer (Jacob) wrote the station's systems-check terminal, then left in a hurry.
The program is a mess. It will not even compile.

Your mission: **find and fix every bug in `Program.cs`** so the terminal works
exactly the way its comments say it should.

---

## What is in this folder

| File | What it is |
|------|------------|
| `Program.cs` | The broken program. This is the only file you edit. |
| `README.md` | This file. Read all of it before you start. |
| `BUG_LOG.md` | A table you fill in with every bug you find and fix. |
| `StarbaseTerminal.csproj` | Project file. Do not change it. |

---

## The three kinds of bugs

There are **33 bugs** hidden in the program:

| **Syntax errors** | 12 | The program will not compile. The compiler prints an `error` with a line number. |
| **Runtime errors** | 5 | The program compiles, but crashes while running with an `Unhandled exception`, **or** gets stuck in a loop forever. |
| **Logic errors** | 16 | The program compiles and runs without crashing, but the output is **wrong** compared to what the section comment says it should do. |

Some bugs hide behind others. Fixing one compile error can reveal a new compile
error you could not see before. That is normal. Keep going.

---

## How to run the program

Open a terminal in this folder and run:

```bash
dotnet run
```

If the program is stuck in a loop and will not stop, press **Ctrl + C** to kill it.

---

## The rules

1. **Fix, do not rewrite.** Every bug is fixed by changing, adding, or removing
   a small piece of code on or near one line. Never delete a whole section and
   write your own version.
2. **Do not change the comments.** The comments above each section are the
   specification. They tell you what the code is *supposed* to do.
3. **Do not change any text inside quotes** (prompts and messages), unless
   the bug is *in* the quotes (for example, a missing quotation mark).
4. **Only use what we have learned in class:** variables, `Console.Write`,
   `Console.WriteLine`, `Console.ReadLine`, `int.Parse`, concatenation with `+`,
   `if / else if / else`, comparison and equality operators, `&&` and `||`,
   `while`, `do while`, `for`, and string indexes like `name[0]` and `name.Length`.
5. **Log every bug** in `BUG_LOG.md` as you fix it. One row per bug.

---

## Suggested strategy

**Step 1: Make it compile.**
Run `dotnet run`. Read the **first** error (they are listed by line number),
go to that line, fix it, and run again. Do not try to fix all twelve at once.

**Step 2: Make it run to the end.**
Once it compiles, run it and type sensible answers. When it crashes, read the
exception name and the `line` number at the bottom of the message:
 

**Step 3: Make it correct.**
When the program runs all the way through, compare your output **line by line**
with the sample run below. Then test the boundary cases in the checklist.
Every difference is a logic error. Common culprits: `<` versus `<=`, `>` versus
`>=`, `&&` versus `||`, `=` versus `+=`, `+` versus `*`, `/` versus `%`,
whole-number division that throws away decimals, the wrong variable being
printed, and statements that sit inside a loop's `{ }` when they should be
outside (or the other way round).

---

## Sample run

When every bug is fixed, typing the answers shown below produces **exactly**
this output. (The values you type are shown after each prompt.)

```
==========================================
    STARBASE-7  SYSTEMS CHECK TERMINAL
==========================================

Enter your crew name: Nova
Welcome aboard, Nova!
First letter of your name: N
Last letter of your name:  a
Your badge ID is: N-4

Enter your age: 34
Clearance level: OFFICER
Airlock access: GRANTED

Enter the 4-digit airlock code: 1234
Incorrect code.
Enter the 4-digit airlock code: 2468
Airlock open! Attempts used: 2

Letter 1: O
Letter 2: R
Letter 3: I
Letter 4: O
Letter 5: N
Backwards: NOIRO

Fuel level for Tank 1: 80
Fuel level for Tank 2: 65
Fuel level for Tank 3: 90
Fuel level for Tank 4: 42
Fuel level for Tank 5: 85
Total fuel: 362
Average fuel level: 72.4
Tanks below 50%: 1

How many ration packs do you need? 3
Subtotal: 36 credits
Shipping: 5 credits
Final total: 44.6 credits

10
9
8
7
6
5
4
3
2
1
LIFTOFF!

Ping 1
Ping 2
Ping 3
Ping 4
Ping 5
Signal locked.

How many rows for the star map? 4
*
**
***
****

Enter a docking bay number (1-20): 7
Bay 7 is on the STARBOARD side

How many crew members are sharing rations? 3
Each crew member gets: 33 credits
Left over: 1 credits

========== FINAL REPORT ==========
Crew member:     Nova
Clearance:       OFFICER
Average fuel:    72.4%
Airlock opened:  True
Systems check complete. Safe travels, Nova!
```

---

## Boundary checklist

The sample run above does **not** catch every logic error. Run the program
again with these inputs and check the results:

- [ ] Age **17** prints `CADET` and `Airlock access: DENIED`.
- [ ] Age **18** prints `OFFICER` and `Airlock access: GRANTED`.
- [ ] Age **64** prints `OFFICER`. Age **65** prints `COMMANDER`.
- [ ] Typing **three wrong codes** prints `Incorrect code.` three times, then
      `Airlock LOCKED.` The final report shows `Airlock opened:  False`.
- [ ] Getting the code right on the **first try** prints `Attempts used: 1`.
- [ ] Fuel levels **10, 20, 30, 40, 50** print `Total fuel: 150`,
      `Average fuel level: 30`, and `Tanks below 50%: 4`.
- [ ] Ordering **10** ration packs prints `Bulk order: shipping is FREE` and
      `Final total: 132 credits`.
- [ ] Star map with **3** rows prints exactly `*`, `**`, `***`.
- [ ] Bay **8** is on the `PORT` side. Bay **21** and bay **0** print `Invalid bay number`.
- [ ] **4** crew members get `25` credits each with `0` left over.

---

## What to hand in

1. Your fixed `Program.cs`.
2. Your completed `BUG_LOG.md` with **one row for every bug** (33 rows): the
   section, the line number, the kind of bug, what was wrong, and how you
   fixed it. Explaining *why* it was wrong is the most important column.

Good luck, crew member. STARBASE-7 is counting on you.
