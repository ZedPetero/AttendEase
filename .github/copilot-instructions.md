# Copilot Instructions

## General Guidelines
- Ensure per-student selection logic and persistence remains.
- Rows must receive `StudentId`, `SectionId`, and `AttendanceDate` when created.
- UC_StudentRow instances must be initialized with `StudentId`, `SectionId`, and `AttendanceDate` when created in UC_Attendance and call `SetSelectedStatus` on creation.

## UI Customization
- UC_StudentRow must not set button colors programmatically; user will control colors in designer.
- UC_StudentRow should wire button click handlers in the constructor and maintain per-row selection state without affecting other rows.
- Per-row selection must only affect that row.