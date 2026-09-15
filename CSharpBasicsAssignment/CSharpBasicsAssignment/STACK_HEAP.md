Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
Order o2 = o1;
o2.IsPaid = true;


STACK                         HEAP
┌──────────────┐             ┌─────────────────────┐
│ o1           │             │ Order               │
│ 0x100        │────────────►│ OrderId = 1         │
└──────────────┘             │ CustomerName = Ali  │
                             │ IsPaid = false      │
                             └─────────────────────┘
o1 stores a reference to the Order object, while the Order object itself is on the heap.


STACK                         HEAP
┌──────────────┐             ┌─────────────────────┐
│ o1           │──┐          │ Order               │
│ 0x100        │  │───────► │ OrderId = 1          │
└──────────────┘  │          │ CustomerName = Ali  │
                  │          │ IsPaid = false      │
┌──────────────┐  │          └─────────────────────┘
│ o2           │──┘
│ 0x100        │
└──────────────┘
o2 copies the same reference as o1, so both variables point to the same Order object.


STACK                         HEAP
┌──────────────┐             ┌─────────────────────┐
│ o1           │──┐          │ Order               │
│ 0x100        │  │          │ OrderId = 1         │
└──────────────┘  ├────────► │ CustomerName = Ali  │
                  │          │ IsPaid = true       │
┌──────────────┐  │          └─────────────────────┘
│ o2           │──┘
│ 0x100        │
└──────────────┘
Changing IsPaid through o2 updates the same heap object, so o1 sees the same change.

### What would be different with structs?

If Order were a struct, it would be a value type like Point from Part C.
Assigning `o2 = o1` would copy the value instead of copying a reference, so o1 and o2 would contain separate copies.
Changing o2.IsPaid would not change o1.IsPaid.