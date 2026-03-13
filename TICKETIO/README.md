# Ticketio
|-----|
## GOAL
This project has the objective to create a system to manager tickets from events.
The client must be able to see the event, name, data, price, setor of the tickets.
## 1. Events
Create a screen event, where the user can insert information about the concert. the user must be able to set
- Name;
- Date;
- Value;
- Max Capacity;
- Number of tickets sold.
## 2. Tickets
Every ticket must have be linked to one person, so every ticket must have:
- Name;
- Document (CPF);
- Related Event.
### 2.1. Types of tickets
It will be 3 types of tickets:
- Simple;
- VIP;
- Exclusive.
Where the values of ticket VIP will be Event Value +30% of its price. And EXCLUSIVE will be Event value +60%.
## Rules
- Show the data of the tickets;
- Show the value of the ticket;
- Verify if the ticket who will be sold will pass the max capacity;
- Show the number of Tickets sold to the Event.