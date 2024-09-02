import React from "react";
import { Formik, Form, Field, ErrorMessage } from "formik";
import * as Yup from "yup";

const validationSchema = Yup.object({
  username: Yup.string().required("Username is required"),
  password: Yup.string().required("Password is required"),
});

const Login = () => {
  return (
    <Formik
      initialValues={{ username: "", password: "" }}
      validationSchema={validationSchema}
      onSubmit={(values) => {
        console.log("Form submitted successfully", values);
      }}
    >
      <Form>
        <table>
          <tr>
            <td>UserName</td>
            <td>
              <Field type="text" name="username" />
            </td>
            <td>
              <ErrorMessage name="username" component="td" />
            </td>
          </tr>
          <tr>
            <td>Password</td>
            <td>
              <Field type="password" name="password" />
            </td>
            <td>
              <ErrorMessage name="password" component="td" />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button type="submit">Submit</button>
            </td>
          </tr>
        </table>
      </Form>
    </Formik>
  );
};

export default Login;
