-- Create Counties Table
CREATE TABLE Counties (
    CountyID INT PRIMARY KEY,
    CountyName NVARCHAR(255),
);

-- Insert Data for Story, Greene, Tama County
INSERT INTO Counties (CountyID, CountyName)
VALUES 
    (169, 'Story'),
    (73, 'Greene'),
    (171, 'Tama');

--  Adjacency Information 
CREATE TABLE CountyAdjacency (
    CountyID INT,
    AdjacentCountyID INT
);

-- Insert Adjacency Information (simplified example)
INSERT INTO CountyAdjacency (CountyID, AdjacentCountyID)
VALUES 
    (169, 127), -- Story County is adjacent to Marshall, Boone, Hamilton, Hardin, Polk
    (169, 15),
    (169, 79),
    (169, 83),
    (169, 153),
    (171, 127), -- Tama County is adjacent to Marshall, Poweshiek , Iowa County , Benton , Black Hawk 
    (171, 157),
    (171, 95),
    (171, 11),
    (171, 13),
    (73, 15), -- Greene County is adjacent to Boone, Story, Carroll County , Calhoun , Guthrie, Webster 
    (73, 169),
    (73, 27),
    (73, 25),
    (73, 77),
    (73, 187);

    
