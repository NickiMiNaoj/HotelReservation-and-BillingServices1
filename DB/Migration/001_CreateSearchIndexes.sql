-- Create Indexes for Fast LIKE Search Queries
-- User Story: As a developer, I want to write indexed search queries, so that database lookups execute fast.
-- Acceptance Criteria: Runs SELECT queries with LIKE filters on indexed columns (e.g., Guest Name, Room ID).

-- Indexes on tblRooms table
-- Index on RoomNumber for prefix LIKE searches (e.g., LIKE 'ABC%')
CREATE INDEX idx_RoomNumber ON tblRooms(RoomNumber);

-- Index on RoomType for filtering and LIKE searches
CREATE INDEX idx_RoomType ON tblRooms(RoomType);

CREATE INDEX idx_RoomStatus ON tblRooms(RoomStatus);

CREATE INDEX idx_RoomStatus_RoomNumber ON tblRooms(RoomStatus, RoomNumber);


CREATE INDEX idx_Username ON tblUsers(Username);

CREATE INDEX idx_FullName ON tblUsers(FullName);

CREATE INDEX idx_Role ON tblUsers(Role);

CREATE INDEX idx_Role_FullName ON tblUsers(Role, FullName);
