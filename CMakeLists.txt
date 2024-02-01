cmake_minimum_required(VERSION 3.0.0)
project(Password++ VERSION 1.0.0)

add_executable(Password++ ./C++/main.cpp)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)
