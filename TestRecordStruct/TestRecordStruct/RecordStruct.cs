namespace TestRecordStruct;

public record struct RecordStruct(string name, string test); // Page가 열릴때에도 Event가 올라옵니다.

// public record class RecordStruct(string name, string test); // Event가 정상적으로 동작합니다.
