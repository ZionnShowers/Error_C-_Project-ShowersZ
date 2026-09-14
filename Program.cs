//Zionn Showers
//9-14-2026
//Check reflection and bug fixes
//Peer Review: Valery Lot
//Review: Code worked up to Section 10. Bug log looks clean and organized. Didn't seem to get a chance to finish the reflection part yet.
// ============================================================
//   STARBASE-7  SYSTEMS CHECK TERMINAL
// ============================================================
//   This program walks a new crew member through a systems
//   check on the space station STARBASE-7.
//
//   Every section starts with a comment that describes EXACTLY
//   what that section is supposed to do. Read the comment, read
//   the code, run the program, and decide whether the code really
//   does what the comment says.
//
//   WARNING: This program is full of bugs. Your job is to find
//   and fix every one of them. See README.md for instructions.
// ============================================================

Console.WriteLine("==========================================");
Console.WriteLine("    STARBASE-7  SYSTEMS CHECK TERMINAL");
Console.WriteLine("==========================================");
Console.WriteLine();


// ---------- SECTION 1: CREW LOGIN ----------
// Ask for the crew member's name and greet them.
// Then print the FIRST letter and the LAST letter of the name.
// Finally build a badge ID made of: the first letter, a dash,
// and the number of letters in the name.
//   Example: the name "Nova" gives the badge ID "N-4"

Console.Write("Enter your crew name: ");
string crewName = Console.ReadLine();

Console.WriteLine("Welcome aboard, " + crewName + "!");

char firstLetter = crewName[0];
char lastLetter = crewName[crewName.Length - 1];

Console.WriteLine("First letter of your name: " + firstLetter);
Console.WriteLine("Last letter of your name:  " + lastLetter);

string badgeId = firstLetter + "-" + crewName.Length;
Console.WriteLine("Your badge ID is: " + badgeId);
Console.WriteLine();


// ---------- SECTION 2: CLEARANCE LEVEL ----------
// Ask for the crew member's age.
// Rules:
//   - Younger than 18              -> "CADET"
//   - 18 up to and including 64    -> "OFFICER"
//   - 65 or older                  -> "COMMANDER"
// Print the clearance level.
// Then, if the crew member is an OFFICER or a COMMANDER, print
// "Airlock access: GRANTED". Otherwise print "Airlock access: DENIED".

Console.Write("Enter your age: ");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

string clearance;

if (age <= 18)
{
    clearance = "CADET";
}
else if (age <= 64)
{
    clearance = "OFFICER";
}
else
{
    clearance = "COMMANDER";
}

Console.WriteLine("Clearance level: " + clearance);

if (clearance == "OFFICER" || clearance == "COMMANDER") //
{
    Console.WriteLine("Airlock access: GRANTED");
}
else
{
    Console.WriteLine("Airlock access: DENIED");
}
Console.WriteLine();


// ---------- SECTION 3: AIRLOCK CODE ----------
// The secret airlock code is 2468.
// Keep asking for the code until the crew member gets it right,
// but allow a MAXIMUM of 3 attempts.
// After every wrong attempt print "Incorrect code."
// If they get it right, print "Airlock open! Attempts used: X"
// (where X is how many tries it took).
// If they use all 3 attempts and never get it, print "Airlock LOCKED."

int secretCode = 2468;
int attempts = 0;
bool airlockOpen = false;

do
{
    Console.Write("Enter the 4-digit airlock code: ");
    int codeGuess = int.Parse(Console.ReadLine());
    attempts = attempts + 1;

    if (codeGuess == secretCode)
    {
        airlockOpen = true;
    }
    else
    {
        Console.WriteLine("Incorrect code.");
    }
} while (airlockOpen == false && attempts < 3);

if (airlockOpen)
{
    Console.WriteLine("Airlock open! Attempts used: " + attempts);
}
else
{
    Console.WriteLine("Airlock LOCKED.");
}
Console.WriteLine();


// ---------- SECTION 4: CALL SIGN ----------
// The station's call sign is stored in the string below.
// Remember: the first letter is at index 0, the last letter is at
// index Length - 1.
// Print each letter of the call sign on its own line, numbered
// starting from 1, like this:
//   Letter 1: O
//   Letter 2: R
//   ...
// Then print the call sign BACKWARDS on one line, like this:
//   Backwards: NOIRO

string callSign = "ORION";

for (int i = 0; i <= callSign.Length - 1; i++)
{
    Console.WriteLine("Letter " + (i + 1) + ": " + callSign[i]);
}

Console.Write("Backwards: ");
for (int i = callSign.Length - 1; i >= 0; i--)
{
    Console.Write(callSign[i]);
}
Console.WriteLine();
Console.WriteLine();


// ---------- SECTION 5: FUEL TANK REPORT ----------
// There are 5 fuel tanks. Ask for the fuel level (a whole-number
// percent) of each tank, one at a time, numbered Tank 1 to Tank 5:
//   Fuel level for Tank 1: 80
//   Fuel level for Tank 2: 65
//   ...
// Then print the TOTAL of all five levels and the AVERAGE level.
// The average must keep its decimals.
//   Example: 80, 65, 90, 42, 85 -> total 362, average 72.4
// Finally print how many tanks are below 50%.

double totalFuel = 0;
int lowTanks = 0;

for (int tank = 1; tank < 6; tank++)
{
    Console.Write("Fuel level for Tank " + tank + ": ");
    int level = int.Parse(Console.ReadLine());

    totalFuel += level;

    if (level < 50)
    {
        lowTanks++;
    }
}

double averageFuel = totalFuel / 5;

Console.WriteLine("Total fuel: " + totalFuel);
Console.WriteLine("Average fuel level: " + averageFuel);
Console.WriteLine("Tanks below 50%: " + lowTanks);
Console.WriteLine();


// ---------- SECTION 6: SUPPLY ORDER ----------
// Ration packs cost 12 credits each.
// Ask how many ration packs to order.
// Print the subtotal (price multiplied by quantity).
// The final total is the subtotal plus a 10% docking fee
// (in other words, subtotal times 1.10).
// If the quantity is 10 or more, print "Bulk order: shipping is FREE".
// Otherwise print "Shipping: 5 credits" and add 5 credits to the total.
// Finally print the final total.
//   Example: 3 packs -> subtotal 36, total 39.6, plus shipping = 44.6

int packPrice = 12;
Console.Write("How many ration packs do you need? ");
int quantity = int.Parse(Console.ReadLine());

int subtotal = packPrice * quantity; 
Console.WriteLine("Subtotal: " + subtotal + " credits");

double finalTotal = subtotal * 1.10;

if (quantity >= 10)
{
    Console.WriteLine("Bulk order: shipping is FREE");
}
else
{
    Console.WriteLine("Shipping: 5 credits");
    finalTotal += 5;
}

Console.WriteLine("Final total: " + finalTotal + " credits");
Console.WriteLine();


// ---------- SECTION 7: LAUNCH COUNTDOWN ----------
// Count down from 10 to 1, printing each number on its own line.
// After the countdown is finished, print "LIFTOFF!" exactly once.

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("LIFTOFF!");
Console.WriteLine();

// ---------- SECTION 8: SIGNAL PINGS ----------
// Send exactly 5 pings. Print "Ping 1", "Ping 2", ... "Ping 5",
// one per line, then print "Signal locked."

int pings = 1;
while (pings <= 5)
{
    Console.WriteLine("Ping " + (pings++)); //--------
}
Console.WriteLine("Signal locked.");
Console.WriteLine();


// ---------- SECTION 9: STAR MAP ----------
// Ask how many rows the star map should have.
// Print a triangle of stars: row 1 has 1 star, row 2 has 2 stars,
// row 3 has 3 stars, and so on, up to the number of rows entered.
//   Example for 3 rows:
//   *
//   **
//   ***

Console.Write("How many rows for the star map? ");
int rows = int.Parse(Console.ReadLine());

for (int row = 1; row <= rows; row++)
{
    for (int star = 1; star <= row; star++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();


// ---------- SECTION 10: DOCKING BAY ----------
// Ask for a docking bay number. Valid bay numbers are 1 to 20.
// If the number is outside that range, print "Invalid bay number".
// Otherwise:
//   - EVEN bay numbers are on the PORT side
//   - ODD bay numbers are on the STARBOARD side
// Print "Bay X is on the PORT side" or "Bay X is on the STARBOARD side".

Console.Write("Enter a docking bay number (1-20): ");
int bay = int.Parse(Console.ReadLine());

if (bay < 1 || bay > 20)
{
    Console.WriteLine("Invalid bay number");
}
else if (bay % 2 == 0)
{
    Console.WriteLine("Bay " + bay + " is on the PORT side");
}
else
{
    Console.WriteLine("Bay " + bay + " is on the STARBOARD side");
Console.WriteLine();
}

// ---------- SECTION 11: RATION SPLIT ----------
// There are 100 ration credits to split evenly between the crew.
// Ask how many crew members there are (assume at least 1).
// Print how many WHOLE credits each crew member gets, and how many
// credits are left over.
//   Example: 100 credits and 3 crew -> each gets 33, 1 left over.

int rationCredits = 100;
int crewCount = 0;

int perMember = rationCredits / crewCount;
int leftover = rationCredits / crewCount;

Console.Write("How many crew members are sharing rations? ");
crewCount = int.Parse(Console.ReadLine());

Console.WriteLine("Each crew member gets: " + perMember + " credits");
Console.WriteLine("Left over: " + leftover + " credits");
Console.WriteLine();


// ---------- SECTION 12: FINAL REPORT ----------
// Print a summary using values from the earlier sections:
// the crew name, the clearance level, the average fuel level,
// and whether the airlock was opened (True or False).
// End with "Systems check complete. Safe travels, NAME!"

Console.WriteLine("========== FINAL REPORT ==========");
Console.WriteLine("Crew member:     " + crewName);
Console.WriteLine("Clearance:       " + badgeId);
Console.WriteLine("Average fuel:    " + averageFuel + "%");
Console.WriteLine("Airlock opened:  " + airlockOpen);
Console.WriteLine("Systems check complete. Safe travels, " + crewName + "!");
