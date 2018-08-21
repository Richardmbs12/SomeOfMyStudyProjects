package io.bcteam.connection;

import com.mongodb.*;

public class ConnectionDB {

    public DB getDatabase(){
        //
        MongoClient mongoClient = new MongoClient("localhost", 27017);

        //switch to database called svmDB
        DB database = mongoClient.getDB("svmDB");

        return database;
    }
}
