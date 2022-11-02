# CMake generated Testfile for 
# Source directory: C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo
# Build directory: C:/Users/429195-10/Desktop/Build/modules/photo
# 
# This file includes the relevant testing commands required for 
# testing this directory and lists subdirectories to be tested as well.
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_test_photo "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_test_photod.exe" "--gtest_output=xml:opencv_test_photo.xml")
  set_tests_properties(opencv_test_photo PROPERTIES  LABELS "Main;opencv_photo;Accuracy" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/accuracy" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1321;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1079;ocv_add_accuracy_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;7;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_test_photo "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_test_photo.exe" "--gtest_output=xml:opencv_test_photo.xml")
  set_tests_properties(opencv_test_photo PROPERTIES  LABELS "Main;opencv_photo;Accuracy" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/accuracy" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1321;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1079;ocv_add_accuracy_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;7;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;0;")
else()
  add_test(opencv_test_photo NOT_AVAILABLE)
endif()
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_perf_photo "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_perf_photod.exe" "--gtest_output=xml:opencv_perf_photo.xml")
  set_tests_properties(opencv_perf_photo PROPERTIES  LABELS "Main;opencv_photo;Performance" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/performance" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1220;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;7;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_perf_photo "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_perf_photo.exe" "--gtest_output=xml:opencv_perf_photo.xml")
  set_tests_properties(opencv_perf_photo PROPERTIES  LABELS "Main;opencv_photo;Performance" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/performance" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1220;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;7;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;0;")
else()
  add_test(opencv_perf_photo NOT_AVAILABLE)
endif()
if(CTEST_CONFIGURATION_TYPE MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
  add_test(opencv_sanity_photo "C:/Users/429195-10/Desktop/Build/bin/Debug/opencv_perf_photod.exe" "--gtest_output=xml:opencv_perf_photo.xml" "--perf_min_samples=1" "--perf_force_samples=1" "--perf_verify_sanity")
  set_tests_properties(opencv_sanity_photo PROPERTIES  LABELS "Main;opencv_photo;Sanity" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/sanity" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1221;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;7;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;0;")
elseif(CTEST_CONFIGURATION_TYPE MATCHES "^([Rr][Ee][Ll][Ee][Aa][Ss][Ee])$")
  add_test(opencv_sanity_photo "C:/Users/429195-10/Desktop/Build/bin/Release/opencv_perf_photo.exe" "--gtest_output=xml:opencv_perf_photo.xml" "--perf_min_samples=1" "--perf_force_samples=1" "--perf_verify_sanity")
  set_tests_properties(opencv_sanity_photo PROPERTIES  LABELS "Main;opencv_photo;Sanity" WORKING_DIRECTORY "C:/Users/429195-10/Desktop/Build/test-reports/sanity" _BACKTRACE_TRIPLES "C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVUtils.cmake;1726;add_test;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1221;ocv_add_test_from_target;C:/Users/429195-10/Desktop/opencv-4.5.3/cmake/OpenCVModule.cmake;1080;ocv_add_perf_tests;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;7;ocv_define_module;C:/Users/429195-10/Desktop/opencv-4.5.3/modules/photo/CMakeLists.txt;0;")
else()
  add_test(opencv_sanity_photo NOT_AVAILABLE)
endif()
