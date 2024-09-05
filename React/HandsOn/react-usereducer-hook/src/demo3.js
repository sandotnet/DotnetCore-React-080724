import React, { useReducer } from "react";
import "./demo3.css";

// Reducer function
const taskReducer = (state, action) => {
  switch (action.type) {
    case "ADD_TASK":
      return {
        ...state,
        tasks: [...state.tasks, action.payload],
      };
    case "UPDATE_TASK":
      return {
        ...state,
        tasks: state.tasks.map((task) =>
          task.id === action.payload.id
            ? { ...task, ...action.payload.updates }
            : task
        ),
      };
    case "DELETE_TASK":
      return {
        ...state,
        tasks: state.tasks.filter((task) => task.id !== action.payload),
      };
    default:
      return state;
  }
};

const Demo3 = () => {
  // Initial state
  const initialState = {
    tasks: [],
  };

  // useReducer hook
  const [state, dispatch] = useReducer(taskReducer, initialState);

  const addTask = (task) => {
    dispatch({ type: "ADD_TASK", payload: task });
  };

  const updateTask = (taskId, updates) => {
    dispatch({ type: "UPDATE_TASK", payload: { id: taskId, updates } });
  };

  const deleteTask = (taskId) => {
    dispatch({ type: "DELETE_TASK", payload: taskId });
  };

  return (
    <div className="container">
      <h1>Task Manager</h1>
      <ul className="task-list">
        {state.tasks.map((task, index) => (
          <li key={task.id} className="task-item">
            <div>
              <h2>{`${index + 1}. ${task.title}`}</h2>
              <p>{task.description}</p>
              <p>Status: {task.status}</p>
              <div className="button-container">
                <button
                  onClick={() => updateTask(task.id, { status: "completed" })}
                  className="complete-button"
                >
                  Complete
                </button>
                <button
                  onClick={() => deleteTask(task.id)}
                  className="delete-button"
                >
                  Delete
                </button>
              </div>
            </div>
          </li>
        ))}
      </ul>
      <button
        onClick={() =>
          addTask({
            id: Date.now(),
            title: `Task ${state.tasks.length + 1}`,
            description: "",
            status: "pending",
          })
        }
        className="add-button"
      >
        Add Task
      </button>
    </div>
  );
};

export default Demo3;
