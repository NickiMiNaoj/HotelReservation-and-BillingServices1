MERGE [dbo].[tblEmployees] AS target
USING (VALUES
    (N'System Administrator', N'admin',     N'Admin@123', N'Admin',      N'Active'),
    (N'Front Desk Staff',     N'frontdesk', N'Front@123', N'Front Desk', N'Active')
) AS source ([FullName], [Username], [Password], [Role], [AccountStatus])
ON target.[Username] = source.[Username]
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([FullName], [Username], [Password], [Role], [AccountStatus])
    VALUES (source.[FullName], source.[Username], source.[Password], source.[Role], source.[AccountStatus]);