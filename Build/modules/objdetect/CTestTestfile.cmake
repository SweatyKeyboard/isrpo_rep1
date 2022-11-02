# CMake generated Testfile for 
# Source directory: C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect
# Build directory: C:/Users/429195-10/Desktop/Build/modules/objdetect
# 
# This file includes the relevant testing commands required for 
# testing this directory and lists subdirectories to be tested as well.
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_test_objdetect "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_test_objdetectd.exe" "--gtest_output=xml:opencv_test_objdetect.xml")
  set_tests_properties(opencv_test_objdetect PROPERTIES  LABELS "Main;opencv_objdetect;Accuracy" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/accuracy" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1321;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1079;ocv_add_accuracy_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;2;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_test_objdetect "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_test_objdetect.exe" "--gtest_output=xml:opencv_test_objdetect.xml")
  set_tests_properties(opencv_test_objdetect PROPERTIES  LABELS "Main;opencv_objdetect;Accuracy" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/accuracy" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1321;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1079;ocv_add_accuracy_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;2;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;0;")
else()
  add_test(opencv_test_objdetect NOT_AVAILABLE)
endif()
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_perf_objdetect "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_perf_objdetectd.exe" "--gtest_output=xml:opencv_perf_objdetect.xml")
  set_tests_properties(opencv_perf_objdetect PROPERTIES  LABELS "Main;opencv_objdetect;Performance" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/performance" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1220;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;2;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_perf_objdetect "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_perf_objdetect.exe" "--gtest_output=xml:opencv_perf_objdetect.xml")
  set_tests_properties(opencv_perf_objdetect PROPERTIES  LABELS "Main;opencv_objdetect;Performance" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/performance" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1220;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;2;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;0;")
else()
  add_test(opencv_perf_objdetect NOT_AVAILABLE)
endif()
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_sanity_objdetect "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_perf_objdetectd.exe" "--gtest_output=xml:opencv_perf_objdetect.xml" "--perf_min_samples=1" "--perf_force_samples=1" "--perf_verify_sanity")
  set_tests_properties(opencv_sanity_objdetect PROPERTIES  LABELS "Main;opencv_objdetect;Sanity" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/sanity" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1221;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;2;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_sanity_objdetect "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_perf_objdetect.exe" "--gtest_output=xml:opencv_perf_objdetect.xml" "--perf_min_samples=1" "--perf_force_samples=1" "--perf_verify_sanity")
  set_tests_properties(opencv_sanity_objdetect PROPERTIES  LABELS "Main;opencv_objdetect;Sanity" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/sanity" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1221;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;2;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/objdetect/CMakeLists.txt;0;")
else()
  add_test(opencv_sanity_objdetect NOT_AVAILABLE)
endif()
