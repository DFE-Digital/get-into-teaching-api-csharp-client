# Get into Teaching API C# Client

> C# client for the Get into Teaching API.

## Development

You can update the C# client by regenerating it from the Get into Teaching API swaggeer documentation. We need to use v2 of `swagger-codegen`.

```
brew install swagger-codegen@2
swagger-codegen generate -i <swagger_docs_url> -l csharp -o ./lib -c config.json
```

