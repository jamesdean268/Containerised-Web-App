CREATE TABLE "Items" (
  "Id" SERIAL PRIMARY KEY,
  "Name" TEXT NOT NULL
);

INSERT INTO "Items" ("Name") VALUES
  ('Item 1'),
  ('Item 2'),
  ('Item 3');
