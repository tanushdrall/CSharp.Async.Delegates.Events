# CSharp.Async.Delegates.Events

A focused C# console app built to understand three advanced C# concepts deeply:
Delegates, Events, and Async/Await.
Each concept explored separately then combined together.
All code typed manually to build real understanding.

---

## What is this?

This is a **dedicated reference app** for three core C# concepts that every
professional developer uses daily. Built after completing the EF Core apps,
this app focuses purely on C# language features — no database noise.
Every concept understood before moving to the next.

---

## Why this order?

```
Phase 1  →  Delegates first
             foundation of everything
             Events use delegates internally
             Async uses delegates internally

Phase 2  →  Events second
             built on delegates
             publisher/subscriber pattern
             real world order scenario

Phase 3  →  Async/Await third
             Task<T> preferred over Task
             meaningful return values
             deep dive into async concepts
```

---

## Concepts covered

### Phase 1 — Delegates
- Custom delegate declaration
- `Action<T>` — built-in, no return value
- `Func<T>` — built-in, has return value
- `Predicate<T>` — built-in, returns bool
- Multicast delegates `+=`
- Multicast removal `-=`
- Delegate as method parameter
- Lambda expressions with delegates
- Named methods vs lambda

### Phase 2 — Events
- Custom `EventArgs` class (`OrderEventArgs`)
- Publisher class (`OrderProcessor`)
- Two subscriber classes (`NotificationService`, `LoggerService`)
- `EventHandler<T>` declaration
- Null safe event firing `?.Invoke()`
- Multiple subscribers — both notified
- Real world scenario — Order processing
- Timestamp in EventArgs (`ProcessedAt`)

### Phase 3 — Async/Await
- `static async Task Main()` entry point
- `Task<T>` — preferred, returns meaningful value
- `Task` alone — no return value
- Why `async void` avoided
- `await Task.Delay()` — simulate waiting
- Method overloading with async
- `Task.WhenAll` — all tasks run together
- `Task.WhenAny` — fastest task wins
- `CancellationToken` — cancel operations
- `CancellationTokenSource.CancelAfter()` — time based
- Condition based cancellation
- `OperationCanceledException` handling
- `using var cts` — proper disposal
- `IsCancellationRequested` — check state

---

## Key concepts explained

### Delegates
```
Delegate     =  method pointer
                pass method as parameter
                store method as variable
                chain multiple methods
                foundation of Events
```

### Events
```
Event        =  delegate with rules
                only publisher fires
                subscribers just listen
                publisher/subscriber pattern
                real world: Order → Notify + Log
```

### Async/Await
```
Async/Await  =  waiting mechanism
                thread free while waiting
                no blocking
                server scalable
                its own relevance
                NOT part of generics
                advanced C# feature ✅
```

---

## Delegate types comparison

| Type | Parameters | Return | Use case |
|------|-----------|--------|----------|
| Custom | defined by you | defined by you | specific signatures |
| `Action<T>` | yes | void | fire and forget |
| `Func<T>` | yes | T | transform/calculate |
| `Predicate<T>` | T | bool | filter/check |

---

## Task<T> — no limitation on T

```csharp
Task<string>         ✅  →  returns string
Task<int>            ✅  →  returns int
Task<bool>           ✅  →  returns bool
Task<Person>         ✅  →  returns object
Task<List<T>>        ✅  →  returns collection
Task<IActionResult>  ✅  →  MVC
Task<void>           ❌  →  not allowed — use Task
```

---

## Async vs Sync

| Sync | Async |
|------|-------|
| Thread blocks | Thread free |
| One at a time | Multiple handled |
| Legacy approach | Modern standard |
| Mutex needed | No Mutex needed |
| Pre .NET 4.5 | Post .NET 4.5 ✅ |

---

## CancellationToken — two approaches

```csharp
// Time based
cts.CancelAfter(4000);  // cancel after 4 seconds

// Condition based
if (retryCount > 3)
    cts.Cancel();       // cancel on condition ✅
```

---

## Task.WhenAll vs Task.WhenAny

```
WhenAll  →  waits for ALL tasks
             all run together
             returns all results
             real world: send 3 emails,
             wait for all sent ✅

WhenAny  →  waits for FIRST task
             fastest one wins
             others keep running
             real world: call 3 servers,
             use fastest response ✅
```

---

## Important distinctions

```
Generics       →  95% of C# structure
                  type safety, reusability
                  compile time concept

Async/Await    →  its own relevance
                  runtime behaviour
                  performance, scalability
                  advanced feature
                  cannot compare to generics
                  different concerns entirely ✅

API Token      →  authentication/security
                  string key, proves identity

CancellationToken→  async control
                    stops operation
                    same word — different context ✅
```

---

## Project structure

```
CSharp.Async.Delegates.Events/
│
├── DelegateExamples.cs  →  all delegate demos
├── EventDemo.cs         →  publisher/subscriber
├── AsyncDemo.cs         →  async demos
└── Program.cs           →  entry point
```

---

## Sample output

```
=== Running Delegate Demo ===
PrintMessage: Hello from Custom Delegate!
Action says: Hello from Action<T>
Func result: 5 + 7 = 12
Predicate result: Is 10 even? True
PrintMessage: Hello from Multicast Delegate!
PrintUpperMessage: HELLO FROM MULTICAST DELEGATE!
Multicast Removal
PrintMessage: After removal!
=== Delegate as Parameter ===
Before execution
Lambda executing!
After execution
=== Demo Complete ===
Processing order ORD123 for quantity 5...
[Notification] Order ORD123 processed at 09-04-2026
[Logger] Order ORD123 processed at 09-04-2026
Hello from Async Method!
=== Task.WhenAll ===
Hello, Task 1! Welcome to Async Programming!
Hello, Task 2! Welcome to Async Programming!
Hello, Task 3! Welcome to Async Programming!
=== Task.WhenAny ===
First completed: Hello, Fast Task! This message took 500ms
=== CancellationToken ===
Async operation was cancelled!
```

---

## How to run

1. Clone the repo
2. Open in Visual Studio or VS Code
3. Run:
```bash
dotnet run
```

---

## What I learned

- How delegates work as method pointers
- Difference between Action, Func, Predicate
- How multicast delegates chain and remove methods
- How events are delegates with rules
- Publisher/subscriber pattern — real world order processing
- Why `?.Invoke()` is null safe event firing
- Why `Task<T>` preferred over `Task`
- Why `async void` is avoided
- How `Task.WhenAll` runs tasks together
- How `Task.WhenAny` returns fastest result
- How `CancellationToken` controls async operations
- Time based vs condition based cancellation
- Why async/await replaced Mutex in modern C#
- Why legacy apps used Thread + flags instead
- Difference between API Token and CancellationToken
- Logic behind every concept before implementation

---

## Next steps planned

```
⬜  Async + Events + CancellationToken combined
⬜  Custom delegate returning Task<T>
⬜  SOLID principles
⬜  Dependency Injection
⬜  MVC (same entities, same EF Core)
```

---

## Related projects

| Project | Description |
|---------|-------------|
| CSharp.GenericRepository | Generics, patterns, LINQ |
| CSharp.GenericRepository.EFCore | EF Core added |
| CSharp.EFCore.Relationships | Clean EF Core + async |
| CSharp.Async.Delegates.Events | This app — delegates, events, async |

---

## Author notes

> All code typed manually using IntelliSense as a tool — not copy-pasted.
> Small practice apps built alongside for muscle memory.
> Every concept understood before moving to next.
> Root cause of every concept explored before implementation.
> Generics is the soul — async has its own relevance.
> C# is the foundation of everything built here.
