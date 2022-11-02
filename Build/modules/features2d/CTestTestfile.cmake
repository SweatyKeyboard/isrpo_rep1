# CMake generated Testfile for 
# Source directory: C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d
# Build directory: C:/Users/429195-10/Desktop/Build/modules/features2d
# 
# This file includes the relevant testing commands required for 
# testing this directory and lists subdirectories to be tested as well.
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_test_features2d "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_test_features2dd.exe" "--gtest_output=xml:opencv_test_features2d.xml")
  set_tests_properties(opencv_test_features2d PROPERTIES  LABELS "Main;opencv_features2d;Accuracy" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/accuracy" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1321;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1079;ocv_add_accuracy_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;9;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_test_features2d "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_test_features2d.exe" "--gtest_output=xml:opencv_test_features2d.xml")
  set_tests_properties(opencv_test_features2d PROPERTIES  LABELS "Main;opencv_features2d;Accuracy" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/accuracy" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1321;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1079;ocv_add_accuracy_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;9;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;0;")
else()
  add_test(opencv_test_features2d NOT_AVAILABLE)
endif()
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_perf_features2d "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_perf_features2dd.exe" "--gtest_output=xml:opencv_perf_features2d.xml")
  set_tests_properties(opencv_perf_features2d PROPERTIES  LABELS "Main;opencv_features2d;Performance" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/performance" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1220;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;9;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_perf_features2d "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_perf_features2d.exe" "--gtest_output=xml:opencv_perf_features2d.xml")
  set_tests_properties(opencv_perf_features2d PROPERTIES  LABELS "Main;opencv_features2d;Performance" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/performance" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1220;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;9;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;0;")
else()
  add_test(opencv_perf_features2d NOT_AVAILABLE)
endif()
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_sanity_features2d "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_perf_features2dd.exe" "--gtest_output=xml:opencv_perf_features2d.xml" "--perf_min_samples=1" "--perf_force_samples=1" "--perf_verify_sanity")
  set_tests_properties(opencv_sanity_features2d PROPERTIES  LABELS "Main;opencv_features2d;Sanity" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/sanity" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1221;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;9;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_sanity_features2d "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_perf_features2d.exe" "--gtest_output=xml:opencv_perf_features2d.xml" "--perf_min_samples=1" "--perf_force_samples=1" "--perf_verify_sanity")
  set_tests_properties(opencv_sanity_features2d PROPERTIES  LABELS "Main;opencv_features2d;Sanity" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/sanity" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1221;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;9;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/features2d/CMakeLists.txt;0;")
else()
  add_test(opencv_sanity_features2d NOT_AVAILABLE)
endif()
