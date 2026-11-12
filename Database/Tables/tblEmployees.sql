CREATE TABLE [dbo].[tblEmployees]
(
    [EmployeeID]    INT            IDENTITY (1, 1) NOT NULL,
    [FullName]      NVARCHAR (100) NOT NULL,
    [Username]      NVARCHAR (50)  NOT NULL,
    [Password]      NVARCHAR (50)  NOT NULL,
    [Role]          NVARCHAR (20)  NOT NULL,   -- matches the Role dropdown on the login page
    [AccountStatus] NVARCHAR (10)  NOT NULL CONSTRAINT [DF_tblEmployees_AccountStatus] DEFAULT ('Active'),

    CONSTRAINT [PK_tblEmployees] PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
    CONSTRAINT [UQ_tblEmployees_Username] UNIQUE ([Username]),
    CONSTRAINT [CK_tblEmployees_Role] CHECK ([Role] IN ('Admin', 'Front Desk')),
    CONSTRAINT [CK_tblEmployees_AccountStatus] CHECK ([AccountStatus] IN ('Active', 'Inactive'))
);