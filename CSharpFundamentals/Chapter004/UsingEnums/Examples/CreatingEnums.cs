namespace UsingEnums.Examples;

internal enum EmployeeTypeEnum1 {
    Manager, // 0
    Grunt, // 1
    Contractor, // 2
    VicePresident, // 3
}

internal enum EmployeeTypeEnum2 {
    Manager = 102,
    Grunt, // 103
    Contractor, // 104
    VicePresident, // 105
}

internal enum EmployeeTypeEnum3 {
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9,
}

internal enum EmployeeTypeEnum4 : byte {
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9,
}