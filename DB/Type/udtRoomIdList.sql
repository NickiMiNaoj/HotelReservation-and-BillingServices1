-- Table type used to pass several RoomIDs into sp_CreateReservation in one call
CREATE TYPE dbo.udtRoomIdList AS TABLE (
    RoomID INT NOT NULL PRIMARY KEY
);
