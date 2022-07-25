# Orchard performance optimization guidelines

## Orchard performance checklist

When optimizing an Orchard Core site's performance (or just putting it into production) check these points for the most obvious ways for a boost.

- Enable the Response Compression feature to gzip HTTP responses.
- Cookie-less domain and/or CDN is used for static resources (including Media files).
- When doing I/O tasks, use async APIs. Not blocking threads to wait for an I/O task to complete increases the throughput of the server.
- If your application is under heavy load memory usage will inherently increase. If you have more than 4GB of memory and you're on a 64b machine don't be afraid to use a 64b application pool: this will also increase memory usage but the site will be able to use more than what is available for it from the 32b address space. You can set up an application pool to run a 64b worker process simply by setting "Enable 32-Bit Applications" to False (under advanced settings of the AppPool).
- Disable IIS Logging or too chatty Failed Request Tracing.

## Detecting performance bottlenecks

The built-in Mini Profiler module is an easy to use Orchard module for pinpointing (mostly DB-related) bottlenecks quickly, even on a production machine.
