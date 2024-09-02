import React from "react";
import { Formik, Form, Field, ErrorMessage } from "formik";
import * as Yup from "yup";

const validationSchema = Yup.object({
  name: Yup.string()
    .min(2, "Too Short!")
    .max(50, "Too Long!")
    .required("Username is required"),
  email: Yup.string()
    .required("Email is required")
    .email("Invalid Email Address"),
  mobile: Yup.number()
    .required("Mobile is required")
    .matches("[6-9][0-9]{9}", "Invalid Mobile no"),
  username: Yup.string().required("Username is required"),
  password: Yup.string()
    .required("Password is required")
    .min(5, "Password must be 5 char long")
    .matches("[a-z0-9]{5}", "Password not allow special chars"),
});

const Register = () => {
  return (
    <Formik
      initialValues={{
        name: "",
        email: "",
        mobile: "",
        username: "",
        password: "",
      }}
      validationSchema={validationSchema}
      onSubmit={(values) => {
        console.log("Form submitted successfully", values);
      }}
    >
      <div className="container">
        <Form>
          <table className="table">
            <tr>
              <td>Name</td>
              <td>
                <Field type="text" name="name" className="form-control" />
              </td>
              <td>
                <ErrorMessage name="name" component="td" />
              </td>
            </tr>
            <tr>
              <td>Email</td>
              <td>
                <Field type="text" name="email" className="form-control" />
              </td>
              <td>
                <ErrorMessage name="email" component="td" />
              </td>
            </tr>
            <tr>
              <td>mobile</td>
              <td>
                <Field type="number" name="mobile" className="form-control" />
              </td>
              <td>
                <ErrorMessage name="mobile" component="td" />
              </td>
            </tr>
            <tr>
              <td>UserName</td>
              <td>
                <Field type="text" name="username" className="form-control" />
              </td>
              <td>
                <ErrorMessage name="username" component="td" />
              </td>
            </tr>
            <tr>
              <td>Password</td>
              <td>
                <Field
                  type="password"
                  name="password"
                  className="form-control"
                />
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
      </div>
    </Formik>
  );
};

export default Register;
