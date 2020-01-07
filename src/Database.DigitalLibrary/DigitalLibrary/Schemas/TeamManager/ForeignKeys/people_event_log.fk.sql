ALTER TABLE TEAM_MANAGER.PEOPLE_EVENT_LOG
    ADD CONSTRAINT FK_PEOPLE_ID
        FOREIGN KEY (PEOPLE_ID)
            REFERENCES TEAM_MANAGER.PEOPLE (ID);

ALTER TABLE TEAM_MANAGER.PEOPLE_EVENT_LOG
    ADD CONSTRAINT FK_EVENT_ID
        FOREIGN KEY (EVENT_ID)
            REFERENCES TEAM_MANAGER.EVENT (ID);
