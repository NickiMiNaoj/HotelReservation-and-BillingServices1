CREATE TABLE [dbo].[tblRooms]
(
    [RoomID]      INT            IDENTITY (1, 1) NOT NULL,
    [RoomNumber]  NVARCHAR (10)  NOT NULL,
    [Floor]       INT            NOT NULL,
    [RoomType]    NVARCHAR (30)  NOT NULL,
    [NightlyRate] DECIMAL (10, 2) NOT NULL,
    [MaxCapacity] INT            NOT NULL,
    [BedType]     NVARCHAR (20)  NOT NULL,
    [Status]      NVARCHAR (30)  NOT NULL CONSTRAINT [DF_tblRooms_Status] DEFAULT ('Available'),
    [Description] NVARCHAR (500) NULL,
    [Amenities]   NVARCHAR (500) NULL,   -- checked items from the Rooms Maintenance list, comma-separated

    CONSTRAINT [PK_tblRooms] PRIMARY KEY CLUSTERED ([RoomID] ASC),
    CONSTRAINT [UQ_tblRooms_RoomNumber] UNIQUE ([RoomNumber]),
    CONSTRAINT [CK_tblRooms_Floor] CHECK ([Floor] > 0),
    CONSTRAINT [CK_tblRooms_NightlyRate] CHECK ([NightlyRate] >= 0),
    CONSTRAINT [CK_tblRooms_MaxCapacity] CHECK ([MaxCapacity] BETWEEN 1 AND 10),
    CONSTRAINT [CK_tblRooms_BedType] CHECK ([BedType] IN ('Single', 'Twin', 'Queen', 'King')),
    CONSTRAINT [CK_tblRooms_Status] CHECK ([Status] IN ('Available', 'Occupied', 'Needs Housekeeping', 'Under Maintenance'))
);