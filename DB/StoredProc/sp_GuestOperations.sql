CREATE PROCEDURE dbo.sp_GuestOperations
    @Action     NVARCHAR(10),
    @GuestID    INT = NULL,
    @FirstName  NVARCHAR(50) = NULL,
    @LastName   NVARCHAR(50) = NULL,
    @Email      NVARCHAR(100) = NULL,
    @Phone      NVARCHAR(20) = NULL,
    @RoomType   NVARCHAR(50) = NULL,
    @Status     NVARCHAR(20) = NULL,
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- CREATE
    IF @Action = 'CREATE'
    BEGIN
        INSERT INTO dbo.tblGuests (FirstName, LastName, Email, Phone, RoomType, Status, CreatedAt)
        VALUES (
            @FirstName, 
            @LastName, 
            @Email, 
            @Phone, 
            @RoomType, 
            COALESCE(@Status, 'Active'),
            GETDATE()
        );
        
        SELECT SCOPE_IDENTITY() AS NewGuestID;
    END

    -- READ ALL
    ELSE IF @Action = 'READ'
    BEGIN
        SELECT 
            GuestID, 
            FirstName, 
            LastName, 
            Email, 
            Phone, 
            RoomType, 
            Status, 
            CreatedAt, 
            UpdatedAt
        FROM dbo.tblGuests
        WHERE (@GuestID IS NULL OR GuestID = @GuestID)
          AND (@Status IS NULL OR Status = @Status);
    END

    -- SEARCH (Filters by ID, Name, Email, or Phone)
    ELSE IF @Action = 'SEARCH'
    BEGIN
        SELECT 
            GuestID, 
            FirstName, 
            LastName, 
            Email, 
            Phone, 
            RoomType, 
            Status, 
            CreatedAt, 
            UpdatedAt
        FROM dbo.tblGuests
        WHERE ISNULL(@SearchTerm, '') = ''
           OR CAST(GuestID AS NVARCHAR) LIKE '%' + @SearchTerm + '%'
           OR FirstName LIKE '%' + @SearchTerm + '%'
           OR LastName LIKE '%' + @SearchTerm + '%'
           OR Email LIKE '%' + @SearchTerm + '%'
           OR Phone LIKE '%' + @SearchTerm + '%';
    END

    -- UPDATE
    ELSE IF @Action = 'UPDATE'
    BEGIN
        UPDATE dbo.tblGuests
        SET FirstName = COALESCE(@FirstName, FirstName),
            LastName  = COALESCE(@LastName, LastName),
            Email     = COALESCE(@Email, Email),
            Phone     = COALESCE(@Phone, Phone),
            RoomType  = COALESCE(@RoomType, RoomType),
            Status    = COALESCE(@Status, Status),
            UpdatedAt = GETDATE()
        WHERE GuestID = @GuestID;
    END

    -- DELETE
    ELSE IF @Action = 'DELETE'
    BEGIN
        UPDATE dbo.tblGuests
        SET Status = 'Cancelled', 
            UpdatedAt = GETDATE()
        WHERE GuestID = @GuestID;
    END
END;
GO