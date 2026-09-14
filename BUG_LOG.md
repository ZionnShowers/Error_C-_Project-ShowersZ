# Bug Log

**Name:** ______________________

Fill in one row for every bug you find and fix in `Program.cs`. There are
**33 bugs**: 12 syntax, 5 runtime, 16 logic. Keep the rows in line-number order
if you can.

**Kind** must be one of: `Syntax`, `Runtime`, `Logic`.

The first row is a worked example of the level of detail expected (it is **not** one of the 33 bugs).

| # | Section | Line | Kind | What was wrong | How I fixed it |
1 | Section 1 | 32 | Syntax | Missing Quotation | Added quoatation at the exclamation point
2 | Section 2 | 56 | Syntax | Missing Parentheses | Added Parentheses on Console.ReadLine
3 | Section 3 | 97 | Syntax | "I" in int is uppercase| made the "I" in int lowercase
4 | Section 3 | 106 | Syntax | Missing additional = sign | Added another = sign 
5 | Section 5 | 184 | Syntax | Fuel in totalFuel is spelled wrong | Fixed totalFule to total Fuel
6 | Section 6 | 201 | Syntax | Missing ; | Added ; at end 
7 | Section 7 | 217 | Syntax | Missing = sign when adding | Changed "+" into "+="
8 | Section 8 | 241 | Syntax | Missing Parentheses | Put parentheses in between "pings <= 5"
9 | Section 9 | 263 | Syntax | Missing ; | Replaced every "," with ";"
10 | Section 10 | 285 | Syntax | Single quotes don't work | Replaced single quotes with double quotes
11 | Section 10 | 295 | Syntax | Missing ending curly bracket | Added ending curly brackets
12 | Section 12 | 329 | Syntax | The "L" in WriteLine is lowercase | Changed the "L" in WriteLine to uppercase
13 | Section 1 | 34 | Logic | Shows the wrong letter as the first letter | Changed 1 into 0
14 | Section 1 | 35 | Runtime | Error when finding the array number | Added "- 1" by crewName.Length to find the correct array number
15 | Section 2 | 57 | Runtime | crewName as age causes error | Changed crewName into ageInput
16 | Section 3 | 104 | Logic | Airlock would not close after 3 attempts | changed attempts into "attempts + 1"
17 | Section 4 | 143 | Runtime | The numbers are not correctly shown | Put parentheses around "i + 1"
18 | Section 4 | 141 | Runtime | Looks for array that doesn't exist. | Added a - 1 at callSign.Length
19 | Section 5 | 166 | Logic | The total fuel is not showing the decimals
20 | Section 5 | 169 | Logic | Doesn't show fuel level for Tank 5 | Changed "tank < 5" to "tank < 6"
21 | Section 5 | 174 | Logic | Doesn't show correct total fuel amount | Changed = to +=
22 | Section 8 | 243 | Runtime | Pings forever loop without adding up | Changed "pings" to "(pings++)"
23 | Section 6 | 205 | Logic | packPrice and quantity are added instead of multiplied | Changed + into *
24 | Section 6 | 208 | Logic | 0.10 is the incorrect number and causes division instead of multiplication | Changed 0.10 to 1.10
25 | Section 7 | 228 | Logic | Countdown skipped 1 | changed "i > 1" to "i > 0"
26 | Section 7 | 231 | Logic | The message "LIFTOFF!" would appear on every second. | Moved line 231 to line 232
27 | Section 9 | 262 | Logic | Shows the same amount of stars every line instead of adding one. | Changed rows to row
28 | Section 10 | 286 | Logic | Shows incorrect bay side | Changed "bay % 2 == 1" to "bay % 2 == 0"
29 | Section 12 | 325 | Logic | Clearnace shows crew name | changed crewName to badgeId
30 | Section 2 | 76 | Logic | Required to be an officer AND commander, which isn't possible | Changed "&&" to "||" |
31
32
33

## Reflection (a few sentences)

Which bug took you the longest to find, and why?

Which kind of bug (syntax, runtime, logic) do you think is the hardest to catch? Why?
