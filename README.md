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

---

## Why this order?

```
Phase 1  →  Delegates first
             foundation of everything
             Events use delegates
             Async uses delegates internally

Phase 2  →  Events second
             built on delegates
             publisher/subscriber pattern
             real world scenario

Phase 3  →  Async/Await third (coming)
             uses Task<T> not Task
             meaningful return values
             deep dive
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
- Custom `EventArgs` class
- Publisher class (`OrderProcessor`)
- Subscriber classes (`NotificationService`, `LoggerService`)
- `EventHandler<T>` declaration
- Null safe event firing `?.Invoke()`
- Multiple subscribers — both notified
- Real world scenario — Order processing

### Phase 3 — Async/Await (coming)
- `Task` vs `Task<T>` — why `Task<T>` preferred
- `async void` vs `async Task` — why void avoided
- `Task.WhenAll` — run multiple tasks together
- `Task.WhenAny` — first one wins
- `CancellationToken` — cancel long operations
- Exception handling in async
- Async event handlers with `Task<T>`
- Custom delegate returning `Task<T>`

---

## Key concepts explained

### Delegates
```
Delegate     =  method pointer
                pass method as parameter
                store method as variable
                chain multiple methods
```

### Events
```
Event        =  delegate with rules
                only publisher fires
                subscribers just listen
                publisher/subscriber pattern
```

### Async/Await
```
Async/Await  =  waiting mechanism
                thread free while waiting
                no blocking
                server scalable
                its own relevance
                NOT part of generics
                advanced feature ✅
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

## Async vs Sync

| Sync | Async |
|------|-------|
| Thread blocks | Thread free |
| One at a time | Multiple handled |
| Legacy approach | Modern standard |
| Mutex needed | No Mutex needed |
| Pre .NET 4.5 | Post .NET 4.5 ✅ |

---

## Why Task\<T\> over Task

```
Task       →  fire and forget
              no return value
              void equivalent

Task<T>    →  meaningful result
              return value
              caller gets data
              more useful ✅
```

---

## Project structure

```
CSharp.Async.Delegates.Events/
│
├── DelegateExamples.cs  →  all delegate demos
├── EventDemo.cs         →  publisher/subscriber
├── AsyncDemo.cs         →  coming soon
└── Program.cs           →  entry point
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
[Notification] Order ORD123 processed at 08-04-2026
[Logger] Order ORD123 processed at 08-04-2026
```

---

## What I learned

- How delegates work as method pointers
- Difference between Action, Func, Predicate
- How multicast delegates chain methods
- How events are delegates with rules
- Publisher/subscriber pattern
- Why `?.Invoke()` is null safe
- Why async/await is separate from generics
- Why `Task<T>` is preferred over `Task`
- Why async/await replaced Mutex in modern C#
- Logic behind every concept before coding

---

## Important distinctions

```
Generics     →  95% of C# structure
               type safety, reusability
               compile time concept

Async/Await  →  its own relevance
               runtime behaviour
               performance, scalability
               advanced feature
               cannot compare to generics
               different concerns entirely ✅
```

---

## Next steps planned

```
⬜  Phase 3 — Deep Async/Await
⬜  Task<T> in event handlers
⬜  Custom delegate returning Task<T>
⬜  CancellationToken demo
⬜  Task.WhenAll demo
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
> Logic behind everything explored before implementation.
> C# is the soul — generics is the heartbeat.
