CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;
CREATE TABLE "Restrictions" (
    "TelegramId" bigint NOT NULL,
    "Reason" text,
    "TypeResctriction" integer NOT NULL,
    "DateEnd" timestamp without time zone
);

CREATE INDEX "IX_Restrictions_TelegramId" ON "Restrictions" ("TelegramId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20250611074932_Init', '9.0.6');

COMMIT;

