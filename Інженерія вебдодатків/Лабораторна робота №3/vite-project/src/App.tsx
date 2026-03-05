import { CreateTodoBar } from "./components/CreateTodoBar/CreateTodoBar";
import { Header } from "./components/Header/Header";
import { TodoList } from "./components/TodoList/TodoList";
import { TodoProvider } from "./providers/todo.provider";

export const App = () => {
  return (
    <>
      <Header />

      <main className="main">
        <section className="container todo">
          <TodoProvider>
            <CreateTodoBar />

            <TodoList />
          </TodoProvider>
        </section>
      </main>
    </>
  );
};
