package com.adaptionsoft.games.trivia;

import com.adaptionsoft.games.trivia.runner.GameRunner;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.PrintStream;
import java.io.UnsupportedEncodingException;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Paths;

public class GoldenMaster {
    private static final ByteArrayOutputStream outContent = new ByteArrayOutputStream();
    private static final PrintStream originalOut = System.out;
    public static final Charset BYTE_ENCODING = StandardCharsets.UTF_8;

    public static String getResult(int i) {
        String result = null;
        try {
            result = new String(Files.readAllBytes(Paths.get("src","test","resources",String.format("output%d.txt", i))), BYTE_ENCODING);
        } catch (IOException e) {
            result = generateExpectedResult(i);
        }
        return result;
    }

    private static String generateExpectedResult(int i){
        String result = null;
        try {
            System.setOut(new PrintStream(outContent, true, BYTE_ENCODING.name()));
        } catch (UnsupportedEncodingException e) {
            System.err.println("The encoding used to convert the game text into bytes and back could not be found. This will not happen with standard encodings.");
            e.printStackTrace();
        }

        GameRunner.main(new String[]{Integer.toString(i)});

        try {
            Files.write(Paths.get("src","test","resources",String.format("output%d.txt",i)),outContent.toByteArray());
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            result = outContent.toString();
            outContent.reset();
            System.setOut(originalOut);
            try {
                outContent.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        return result;
    }
}
