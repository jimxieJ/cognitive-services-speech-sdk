//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//
#pragma once

#include <type_traits>
#include <memory>

#include <jni.h>

struct JNIEnvironment
{
    explicit JNIEnvironment(JavaVM* vm);
    ~JNIEnvironment();

    JNIEnv* env{ nullptr };
};

JNIEXPORT jint JNI_OnLoad(JavaVM* vm, void* reserved);
JNIEXPORT void JNI_OnUnload(JavaVM* vm, void* reserved);

std::shared_ptr<JNIEnvironment> GetEnvironment();

JavaVM* GetVM() noexcept;

/* Function to execute the callable in the JNIEnv associated with the current thread */
template<typename F>
typename std::result_of<F(JNIEnv*)>::type RunOnEnv(F fn)
{
    auto env = GetEnvironment();
    return fn(env->env);
}

// pragma is needed here to suppress warnings generated by uniqueid.h
#pragma GCC system_header
#include "azure_c_shared_utility/uniqueid.h"