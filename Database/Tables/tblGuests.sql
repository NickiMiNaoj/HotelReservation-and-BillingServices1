-- STARTER VERSION: only here so tblReservations can reference it.
-- The guest procedures, seed data and C# classes come in the Guests step.
CREATE TABLE [dbo].[tblGuests]
(
    [GuestID]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]        NVARCHAR (50)  NOT NULL,
    [LastName]         NVARCHAR (50)  NOT NULL,
    [ContactNumber]    NVARCHAR (20)  NOT NULL,
    [EmailAddress]     NVARCHAR (100) NULL,
    [Nationality]      NVARCHAR (50)  NULL,
    [IDType]           NVARCHAR (30)  NULL,
    [IDNumber]         NVARCHAR (50)  NULL,
    [Address]          NVARCHAR (200) NULL,
    [GuestPreferences] NVARCHAR (500) NULL,

    CONSTRAINT [PK_tblGuests] PRIMARY KEY CLUSTERED ([GuestID] ASC),
    CONSTRAINT [CK_tblGuests_IDType] CHECK ([IDType] IS NULL OR [IDType] IN ('Passport', 'National ID', 'Driver''s License'))
);