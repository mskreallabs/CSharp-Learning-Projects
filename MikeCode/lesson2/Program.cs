// ============================================================
//                 ALL ABOUT OPERATORS IN C#
// ============================================================


// ============================================================
// 1. ARITHMETIC OPERATORS
// ============================================================

int num1 = 10;
int num2 = 6;

// Addition (+)
Console.WriteLine("Addition: " + (num1 + num2));

// Subtraction (-)
Console.WriteLine("Subtraction: " + (num1 - num2));

// Multiplication (*)
Console.WriteLine("Multiplication: " + (num1 * num2));

// Division (/)
// Because num1 and num2 are int, this is INTEGER DIVISION.
// 10 / 6 = 1, not 1.666...
Console.WriteLine("Division: " + (num1 / num2));

// Modulus (%)
// Gives the remainder after division.
// 10 % 6 = 4
Console.WriteLine("Modulus: " + (num1 % num2));


// ============================================================
// 2. INCREMENT AND DECREMENT OPERATORS
// ============================================================

// ++x  = PRE-INCREMENT
// x is increased FIRST, then the new value is used.
//
// x++  = POST-INCREMENT
// The current value is used FIRST, then x is increased.
//
// --x  = PRE-DECREMENT
// x is decreased FIRST, then the new value is used.
//
// x--  = POST-DECREMENT
// The current value is used FIRST, then x is decreased.
//
// Easy memory rule:
//
// PRE  → change first → use
// POST → use first → change


// num1 = 10
// ++num1 changes num1 to 11 BEFORE printing it.
Console.WriteLine("Pre-Increment num1: " + (++num1));

// num2 = 6
// --num2 changes num2 to 5 BEFORE printing it.
Console.WriteLine("Pre-Decrement num2: " + (--num2));

// At this point:
// num1 = 11
// num2 = 5

Console.WriteLine(
    "Values after pre-increment/decrement: num1 = "
    + num1 + ", num2 = " + num2
);


// POST-INCREMENT
// num1++ first gives/uses 11,
// then num1 becomes 12.
Console.WriteLine("Post-Increment num1: " + (num1++));

// POST-DECREMENT
// num2-- first gives/uses 5,
// then num2 becomes 4.
Console.WriteLine("Post-Decrement num2: " + (num2--));


// At this point:
// num1 = 12
// num2 = 4

Console.WriteLine(
    "Final Values after post-increment/decrement: num1 = "
    + num1 + ", num2 = " + num2
);


// ============================================================
// 3. LOGICAL OPERATORS
// ============================================================

bool isTrue = true;
bool isFalse = false;

// && = Logical AND
// true && false = false
Console.WriteLine(
    "Logical AND (isTrue && isFalse): "
    + (isTrue && isFalse)
);

// || = Logical OR
// true || false = true
Console.WriteLine(
    "Logical OR (isTrue || isFalse): "
    + (isTrue || isFalse)
);

// ! = Logical NOT
// !true = false
Console.WriteLine(
    "Logical NOT (!isTrue): "
    + (!isTrue)
);


// ============================================================
// 4. COMPARISON OPERATORS
// ============================================================

// At this point:
// num1 = 12
// num2 = 4

// == means "equal to"
Console.WriteLine(
    "Is num1 equal to num2? "
    + (num1 == num2)
);

// != means "not equal to"
Console.WriteLine(
    "Is num1 not equal to num2? "
    + (num1 != num2)
);

// > means "greater than"
Console.WriteLine(
    "Is num1 greater than num2? "
    + (num1 > num2)
);

// < means "less than"
Console.WriteLine(
    "Is num1 less than num2? "
    + (num1 < num2)
);

// >= means "greater than or equal to"
Console.WriteLine(
    "Is num1 greater than or equal to num2? "
    + (num1 >= num2)
);

// <= means "less than or equal to"
Console.WriteLine(
    "Is num1 less than or equal to num2? "
    + (num1 <= num2)
);


// ============================================================
// 5. COMPLEX EXPRESSION + OPERATOR PRECEDENCE
// ============================================================

// Operator precedence controls the order of operations.
//
// Important order for this expression:
//
// 1. *  /  %
// 2. >  <  >=  <=  ==  !=
// 3. &&
// 4. ||
//
// Therefore:
//
// num1 > num2 || num1 < num2 && num1 * 2 > num2
//
// is interpreted as:
//
// (num1 > num2) ||
// ((num1 < num2) && ((num1 * 2) > num2))

bool Result =
    num1 > num2 ||
    num1 < num2 && num1 * 2 > num2;

Console.WriteLine(
    "Result of complex expression: " + Result
);


// ============================================================
//                    FINAL VALUES
// ============================================================

Console.WriteLine(
    "Final num1 = " + num1
);

Console.WriteLine(
    "Final num2 = " + num2
);