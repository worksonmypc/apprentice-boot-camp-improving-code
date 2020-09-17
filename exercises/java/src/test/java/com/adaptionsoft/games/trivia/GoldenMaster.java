package com.adaptionsoft.games.trivia;

import com.adaptionsoft.games.trivia.runner.GameRunner;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.PrintStream;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Paths;

public class GoldenMaster {
    public static final Charset BYTE_ENCODING = StandardCharsets.UTF_8;

    public static String getResult(int i) {
        String result = null;
        try {
            result = new String(Files.readAllBytes(Paths.get("src", "test", "resources", String.format("output%d.txt", i))), BYTE_ENCODING);
        } catch (IOException e) {
            result = generateExpectedResult(i);
        }
        return result;
    }

    private static String generateExpectedResult(int i) {
        PrintStream originalOut = System.out;
        try (ByteArrayOutputStream outContent = new ByteArrayOutputStream();
             PrintStream interceptingStream = new PrintStream(outContent, true, BYTE_ENCODING.name())) {
            System.setOut(interceptingStream);

            GameRunner.main(new String[]{Integer.toString(i)});

            Files.write(Paths.get("src", "test", "resources", String.format("output%d.txt", i)), outContent.toByteArray());
            return outContent.toString();
        } catch (IOException e) {
            throw new RuntimeException("Failed to generate the expected result for iteration " + i, e);
        }
        finally {
            System.setOut(originalOut);
        }
    }
}
