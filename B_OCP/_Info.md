# Open/Closed principle

In object-oriented programming, the open–closed principle states "software entities should be open for extension, but closed for modification"; that is, such an entity can allow its behaviour to be extended without modifying its source code.

In initial code, in order to add more layers of permissions (simulated), we need to modify almost all files, being at the risk of populating bugs. In refactored one, we solved this issue. Now, we can just extend behaviour, without modifying the rest part.