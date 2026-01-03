# CodeSmells

```cmd





=== CH01 Code Smells - solutions\_MZ (Mateusz) ===



\[01] Long Parameter List

Product: Laptop, Category: Electronics, Price: 4 999,99 zł, Stock: 10, Supplier: TechSupplier, Contact: +48 500 600 700

Expected: one line with product + supplier details.



\[02] Duplicated Code

ERROR: \[2026-01-03 12:00:00] Disk not found

WARNING: \[2026-01-03 12:01:00] Low memory

Expected: two lines, one ERROR and one WARNING, with timestamps.



\[03] Message Chains

Cylinder size: 2.0L

Expected: Cylinder size: 2.0L



\[04] Refused Bequest

Manager working.

Manager attending meeting.

Managing team.

Expected: 3 lines about working/meeting/managing.



\[05] Temporary Fields

\[PdfWriter] Open: Invoice\_12345.pdf

\[PdfWriter] Writing: Invoice Content

\[PdfWriter] Close: Invoice\_12345.pdf

Expected: Open -> Writing -> Close (in this order).



\[06] Data Clumps

Event: Hackathon, Date: 2026-02-01, Location: Warsaw

Expected: one line with event name/date/location.



\[07] Inappropriate Intimacy

Course completed: True, credits: 3

Expected: completed=True, credits=3



\[08] Long Message Chain

Teacher: Jan Nowak

Expected: Teacher: Jan Nowak



\[09] Divergent Change

User logged in.

Generating user report for: mateusz

User logged out.

Expected: logged in -> report -> logged out



\[10] Parallel Inheritance Hierarchies

\[FILE] Starting export...

<xml>Hello</xml>

\[FILE] Export finished.

\[DB] Starting export...

{ "data": "World" }

\[DB] Export finished.

Expected: two runs with different logger/exporter combos.



\[11] Feature Envy

Total with shipping: 1200,00

Expected: 1000 + 20% = 1200



\[12] God Class

Managing users.

Configuring system.

Log: Daily admin tasks executed.

System report generated.

Expected: manage users -> configure -> log -> report.



\[13] Switch Statements (Strategy)

CreditCard fee: 20,00 (expected 20)

PayPal fee: 30,00 (expected 30)

BankTransfer fee: 10,00 (expected 10)



\[14] Large Class

Processing orders.

Managing inventory.

Coordinating deliveries.

Handling returns.

Expected: orders -> inventory -> deliveries -> returns



\[15] Primitive Obsession

Product: Mouse, Category: Accessories, Price: 99,99, Quantity: 5

Expected: one line with product details



\[16] Data Class

Name: Keyboard

Formatted price: 250,50 zł

In stock: True (expected True)



\[17] Comments

Payment processed.

Account updated.

Receipt created.

Expected: Payment processed -> Account updated -> Receipt created



\[18] Middle Man

Invoice saved: 1 (Sample invoice)

Expected: Invoice saved: 1 (Sample invoice)



\[19] Long Method (encapsulation in GradeBook)

Grade: 90, Finalized: True

Expected: Grade=90, Finalized=True



\[20] Speculative Generality

Handling HTTP request: https://example.com

Handling file request: report.pdf

Expected: HTTP handled + File handled



\[21] Lazy Class

Notification sent: Build completed

Expected: Notification sent: Build completed



\[22] Shotgun Surgery

Order created for customer Mateusz.

Order 9D0EEE91 saved.

Expected: Order created... then Order <id> saved.





=== DONE ===

